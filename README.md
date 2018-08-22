# Deipax - Cloning library

A high performance, customizable, deep cloning library.


## Why use this cloning library?
Many good cloning libraries exist, I chose to write this one out of curiosity (a fun side project) and so I could tailor it to my exact needs.  It is faster than, or as fast as, most I have compared it against and also supports a good range of features.  Some of the feature are:

- It supports polymorphism out of the box.
- It is able to register a initialization delegate for a specific class/struct.
- It is able to register a clone delegate for a specific class/struct so you can supply your own clone logic.
- It is able to register a clone delegate factory for a range of classes/structs so you can supply your own clone logic.
- It is able to skip properties/fields using attributes.  Good for classes/structs authored by you.
- It is able to skip properties/fields using name registration.  Good for classes/structs not authored by you.
- It is able to return properties/fields from the source without cloning using attributes.  Good for classes/structs authored by you (ShallowClone).
- It is able to return properties/fields from the source without cloning using name registration.  Good for classes/structs not authored by you (ShallowClone).

## Sample Usage
var source = new MyClass<int>() { Item = 10 };

 - var target = Cloner.Get(source, new CopyContext());
 - var target = source.GetClone();


## What is cloned by default?
By default all public readable/writable non-static, non-literal properties and fields.  There are several ways to effect how a class/struct is cloned.  You can either decorate your classes with certain attributes, or you can programatically configure cloning behavior using `CloneConfig<T>`.


## Attributed Configuration
Attributes are a good way to change default cloning behavior on classes authored by you.  The attributes of interest are:

- CloneCmdAttribute (classes and structs)
- NoCloneAttribute (properties and fields)
- CloneAttribute (properties and fields)
- ShallowCloneAttribute (classes, structs, properties and fields)

#### CloneCmd, Clone and NoClone Attributes
The constructor for the CloneCmdAttribute accepts an enum with values of "Default", "All" or "None".  If "Default" is selected the default behavior is used (the Clone and NoClone attributes are taken into consideration).  If "All" is selected, all properties and fields will be cloned EXCEPT for the properties and fields (even private members) which are decorated with the NoCloneAttribute.  If "None" is selected no properties or fields will be cloned EXCEPT for the properties and fields (even private members) which are decorated with the CloneAttribute.

Examples:

        [CloneCmd(CloneCmd.None)]
        public class TestClass5
        {
            [Clone]
            private int PropOne { get; set; }

            [Clone]
            private int PropTwo { get; set; }
            private int PropThree { get; set; }
            private int PropFour { get; set; }
        }

        [CloneCmd(CloneCmd.All)]
        public class TestStruct2
        {
            public int PropOne { get; set; }

            [NoClone]
            public int PropTwo { get; set; }
           
            private int PropThree { get; set; }
            
            [NoClone]
            private int PropFour { get; set; }
        }

Why would you not want to clone some fields?  In my case I had a web service that logged all requests sent to it so that we could track work and troubleshoot production issues.  One endpoint was for saving images which took up a lot of database space and provided no benefit, so I decorated the property on the request which held the image byte array with a NoClone attribute.  I would then clone the request, serialize it and then save it to the database without the extra image data.

#### ShallowClone
The ShallowClone attribute is rather simple.  If a class, struct, property or field is decorated with this attribute, anytime it is encountered it will be returned from the source without cloning or manipulation of any kind.

Examples:

        [ShallowClone]
        class HelperClass1
        {
        }

        class HelperClass2
        {
        }
        
        class HelperClass5
        {
            public HelperClass1 PropOne { get; set; }
        }
        
        class HelperClass7
        {
            [ShallowClone]
            public HelperClass2 FieldOne;

            public HelperClass2 FieldTwo;
        }
        
Since HelperClass1 is decorated, anytime an instance of this type is found in the object graph it will be returned without cloning.  So if you were to clone an instance of HelperClass5 both the target and source would be pointing at the same instance of HelperClass1.  For HelperClass7, only that FieldOne would be shallow cloned.  Any other instance of HelperClass2 would go through the normal cloning procedure.


## Programmatic Configuration
All of the configuration options available using attributes are also available using `CloneConfig<T>`.  While it is easy enough to attribute classes authored by yourself, you can not decorate classes you use that are authored by another but you may still need to manipulate cloning behavior of that class.  These changes should be executed only once, likely during initialization, before any clone calls are made.  If clone calls are made before the programattic configuration is executed, the delegate used for cloning will have already been constructed and cached so the changes will not show up.

Examples:

- `CloneConfig<TestStruct2>.CloneCmd = CloneCmd.All;`
- `CloneConfig<TestStruct2>.NoClone(x => x.PropTwo);`
- `CloneConfig<TestStruct2>.NoClone("PropFour");`
- `CloneConfig<HelperClass1>.ShallowCloneType = true;`
- `CloneConfig<HelperClass7>.ShallowClone(x => x.FieldOne);`


## Registering a initialization delegate
Sometimes it is necessary to provide a way of initializing a class or struct before proceeding with the cloning procedure. Some classes do not have a default constructors or the user may need to do some custom work, for this purpose you can use `CloneConfig<T>.Initializer`.  If an initializer is registered, it will be called by the framework instead of the default constructor and then normal cloning work will commence.

Example:

        CloneConfig<Helper5>.Initializer = (x) =>
        {
             return new Helper5(x.Prop);
        };


## Registering a clone delegate
If the customization options available are not enough, the user can register a clone degelate.  That delegate is responsible for the entire cloning procedure of an object including initialization and checking the CopyContext if necessary to prevent cyclical traversal of the object graph.

Example:
       
       CloneConfig<Helper1>.CloneDel = (source, context) =>
       {
           // Perform instantiation and clone work here
           ...
           return clonedInstance;
       };


## Registering a clone delegate factory
If the customization options available are not enough, the user can register a clone degelate factory.  The factory is responsible for determining if it supports a type for cloning and if so returning a delegate which will peform the clone.  That delegate is responsible for the entire cloning procedure of an object including initialization and checking the CopyContext if necessary to prevent cyclical traversal of the object graph.  Typically the factories are useful for generics.

Example:

        class HelperFactory : ICloneDelFactory
        {
            public CloneDel<T> Get<T>()
            {
                if (typeof(T).GetGenericTypeDefinition() == typeof(Helper<>))
                {
                    return CloneHelper;
                }

                return null;
            }

            private static T CloneHelper(T source, CopyContext c)
            {
               // Perform instantiation and clone work here
               ...
               return clonedInstance;
            }
        }

        class Helper<T>
        {
            public T PropOne { get; set; }
        }

        // Register the factory
        CloneConfigHelper.UserFactories.Add(new HelperFactory());


# Deipax - DataAccess library

Access any relational database that provides an Ado.Net implementation in a linq like fashion using extension methods.

*Documentation work in progress*


## Credits 
 - The cloning functionality is heavily base off the [CloneExtensions](https://github.com/MarcinJuraszek/CloneExtensions) project authored by [Marcin Juraszek](https://github.com/MarcinJuraszek).
 - Many performance tweaks and observations came from the [DeepCopy](https://github.com/ReubenBond/DeepCopy) project authored by [Reuben Bond](https://github.com/ReubenBond).
 - The data access was inspired by the [YADAL(Yet Another Data Access Library)](https://github.com/jhgbrt/yadal) project authored by [jhgbrt](https://github.com/jhgbrt).
 
Many changes I have made were to remove inefficiencies and bugs or to add or change functionality and to organize code according my personal preferences.  All bugs or inefficiencies found in the original source, I have offered fixes/observations back to the original authors.
