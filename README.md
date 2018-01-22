# Deipax - Cloning and Data Access library

A high performance, customizable, deep cloning library. Access any relational database in a linq like fashion using extension methods built around Ado.Net.

# Why use this cloning library?
Many good cloning libraries exist, I chose to write this one out of curiosity (a fun side project) and so I could tailor it to my exact needs.  It is decently fast (faster than or as fast as most I have compared it against) and supports a good range of customization.  Some of the customization features are:

- Able to register a initialization delegate for a specific class/struct.
- Able to skip properties/fields using attributes.  Good for classes/structs authored by you.
- Able to skip properties/fields using name registration.  Good for classes/structs not authored by you.
- Able to return properties/fields from the source without cloning using attributes.  Good for classes/structs authored by you.
- Able to return properties/fields from the source without cloning using registration.  Good for classes/structs not authored by you.
- Able register a custom delegate factory for structs/classes not supported out of the box or if you want to supply your own clone logic.

*Documentation work in progress*

Must mention credits - The cloning functionality is based off of CloneExtensions written by Marcin Juraszek.  The data access is based off work by jhgbrt/yadal (yet another data access library).  Many changes I have made were to remove inefficiencies, to add or change functionality and to organize the code according my personal preferences and needs.  All bugs or inefficiencies found in the original source, I have offered modifications back to the original authors.
