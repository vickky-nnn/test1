# FORT Technical Exercise
## Refactoring

* Removed variable declarations in getters, this will cause the creation of variable each time the property is called. Instead used private class level declarations.
* used proper naming conventions for private class variables and properties, by doing this it will become easier to identity/differentiate the class members.
* user switch/conditional operators wherever they are apt to use by avoiding if/else conditions, this will reduce the no. of steps that are called during runtime.
* added Type property for type variable, having public variables is not recommended by Microsoft