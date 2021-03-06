Welcome to my personal github repository.  Over the course of my career I have found some interesting issues that I wanted to further review, this repository is a result of that curiosity.  Currently, there are two libraries (See the individual library wiki pages for usage details):

# Deipax - Cloning library

A high performance, customizable, deep cloning library.

# Deipax - DataAccess library

Access any relational database that provides an Ado.Net implementation in a fluent fashion using extension methods.

# Deipax - Convert

A strongly typed conversion library, with a generic interface, built on top of System.Convert with the intent to avoid the costs associated with boxing/unboxing.

## Credits 
 - The cloning functionality is heavily base off the [CloneExtensions](https://github.com/MarcinJuraszek/CloneExtensions) project authored by [Marcin Juraszek](https://github.com/MarcinJuraszek).
 - Many performance tweaks and observations came from the [DeepCopy](https://github.com/ReubenBond/DeepCopy) project authored by [Reuben Bond](https://github.com/ReubenBond).
 - The data access was inspired by the [YADAL(Yet Another Data Access Library)](https://github.com/jhgbrt/yadal) project authored by [jhgbrt](https://github.com/jhgbrt).
 - Data access interface refinement [Dapper](https://github.com/StackExchange/Dapper).
 
Many changes I have made were to remove inefficiencies and bugs or to add or change functionality and to organize code according my personal preferences.  All bugs or inefficiencies found in the original source, I have offered fixes/observations back to the original authors.
