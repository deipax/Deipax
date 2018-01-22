# Deipax - Cloning and Data Access library

A high performance, customizable, deep cloning library. Access any relational database in a linq like fashion using extension methods built around Ado.Net.


## Why use this cloning library?
Many good cloning libraries exist, I chose to write this one out of curiosity (a fun side project) and so I could tailor it to my exact needs.  It is faster than, or as fast as, most I have compared it against and also supports a good range of features.  Some of the feature are:

- It supports polymorphism out of the box.
- It is able to register a initialization delegate for a specific class/struct.
- It is able to register a clone delegate for a specific class/struct so you can supply your own clone logic.
- It is able to register a clone delegate factory for a range of classes/structs so you can supply your own clone logic.
- It is able to skip properties/fields using attributes.  Good for classes/structs authored by you.
- It is able to skip properties/fields using name registration.  Good for classes/structs not authored by you.
- It is able to return properties/fields from the source without cloning using attributes.  Good for classes/structs authored by you.
- It is able to return properties/fields from the source without cloning using name registration.  Good for classes/structs not authored by you.

## Sample Usage
var source = new MyClass<int>() { Item = 10 };

 - var target = Cloner.Get(source, new CopyContext());
 - var target = source.GetClone();


## What is cloned by default?
By default all public readable/writable non-static, non-literal properties and fields.  There are several ways to effect how a class/struct is cloned.  You can either decorate your classes with certain attributes, or you can programatically configure cloning behavior using `CloneConfig<T>`.


## Attributed Configuration
Attributes are a good way to change default cloning behavior on classes authored by you.  The attributes of interest are:

- CloneCmdAttribute (for classes and structs)
- NoCloneAttribute (for properties and fields)
- CloneAttribute (for properties and fields)

The constructor for the CloneCmdAttribute accepts an enum with values of "Default", "All" or "None".  If "Default" is selected the default behavior is used.  If "All" is selected, all properties and fields will be cloned EXCEPT for the properties and fields (even private members) which are decorated with the NoCloneAttribute.  If "None" is selected no properties or fields will be cloned EXCEPT for the properties and fields (even private members) which are decorated with the CloneAttribute.

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

Why would you not want to clone some fields?  In my case I had a web service that logged all requests sent to it so that we could track work and troubleshoot production issues.  One endpoint was for saving images which took up a lot of database space and provided no benefit.


## Programmatic Configuration



*Documentation work in progress*

## Credits 
 - The cloning functionality is heavily based off of the CloneExtensions project authored by Marcin Juraszek.
 - Many performance tweaks and observations came from the DeepCopy project authored by Reuben Bond.
 - The data access is based off work by jhgbrt/yadal (yet another data access library).
 
Many changes I have made were to remove inefficiencies and bugs or to add or change functionality and to organize code according my personal preferences.  All bugs or inefficiencies found in the original source, I have offered fixes/observations back to the original authors.
