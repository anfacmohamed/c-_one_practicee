Navigation Menu

anfac

c-_one_assignment

Repository navigation

Code Issues Pull requests Actions

c-_one_assignment /week2/

anfac

c-_one_assignment /week2/

Name | Last commit date

.. screenshoots image.png readme readme.md

readme.md

### chapter2

### Topics (1 of 2)

3.1 Reading Input with TextBox Controls 3.2 A First Look at Variables 3.3 Numeric Data Type and Variables 3.4 Performing Calculations 3.5 Inputting and Outputting Numeric Values 3.6 Formatting Numbers with the ToString Method 3.7 Simple Exception Handling 3.8 Using Named Constants 3.9 Declaring Variables as Fields 3.10 Using the Math Class 3.11 More GUI Details 3.12 Using the Debugger to Locate Logic Errors

### Reading Input with TextBox Control

TextBox control is a rectangular area that can accept keyboard input from the user. It is located in the Common Controls group of the Toolbox. Double-click to add it to the form. The default name is textBox.

### The Text Property

A TextBox control’s Text property stores the user inputs. The Text property accepts only string values.

### Data Types

A variable must be declared with a proper data type. The data type specifies the type of data a variable can hold. Many data types are known as primitive data types. They store fundamental types of data, such as strings and integers.

Primitive means basic, simple, or built-in. In C#, primitive data types are already defined by the language.

### Primitive

Common primitive types:

* int — Whole numbers

* double — Decimal numbers

* char — One character

* bool — True or false

* float and decimal — Decimal numbers

### Non-primitive

String Array Class Object Interface

### Variable Names

A variable name identifies a variable. Always choose a meaningful name for variables.

Basic naming conventions:

* The first character must be a letter, uppercase or lowercase, or an underscore (_).

* The name cannot contain spaces.

### String Variables

A string is a combination of characters. A variable of the string data type can hold any combination of characters, such as names, phone numbers, and social security numbers.

The value of a string variable is assigned using the equals operator and surrounded by double quotation marks.

### String Concatenation

Concatenation is the appending of one string to the end of another string. The plus (+) operator is used for concatenation.

### Local Variables and Scope

A local variable belongs to the method in which it was declared. Only statements inside that method can access the variable.

Scope describes the part of a program in which a variable may be accessed.

Lifetime is the time period during which a variable exists in memory while the program is executing.

A local variable is created in memory when the method in which it is declared starts executing. When the method ends, all the method’s local variables are destroyed.

### Duplicate Variable Names

You cannot declare two variables with the same name in the same scope. For example, if you declare a variable named productDescription in an event handler, you cannot declare another variable with that name in the same event handler. However, you can have variables with the same name declared in different methods.

### Assignment Compatibility

You can assign a value to a variable only if the value is compatible with the variable’s data type. Only strings are compatible with the string data type.

### Declaring Multiple Variables with One Statement

You can declare multiple variables of the same data type with one declaration statement.

You can break up a long statement so that it spreads across two or more lines. Long variable declarations are sometimes written across multiple lines to make them easier to read.

### 3.3 Numeric Data Types and Variables

If you need to store a number in a variable and use the number in a mathematical operation, the variable must be of a numeric data type.

* double: Real numbers, including numbers with fractional parts.

* decimal: Real numbers stored with greater precision than doubles. Typically used in financial applications.

### Assignment Compatibility for int Variables

You can assign int values to int variables, but you cannot directly assign double or decimal values to int variables without conversion.

### Explicit Conversion with Cast Operators

You can use the cast operator to convert a value from one data type to another. The cast operator is simply the name of the target type enclosed in parentheses.

### Declaring Local Variables with the var Keyword

var is a keyword you can use instead of writing the full type of a variable. The compiler automatically determines the type from the value you assign. This is called type inference.

You must provide an initialization value when declaring a variable with var. The compiler determines the variable’s data type from that value.

The var keyword can only be used to declare local variables, which are variables declared inside a method.

### 3.4 Performing Calculations

Basic calculations, such as arithmetic calculations, can be performed using mathematical operators.

### 3.5 Inputting and Outputting Numeric Values

Input collected from the keyboard is considered a combination of characters, or a string, even if it looks like a number.

A TextBox control reads keyboard input, such as 25.65. However, the TextBox treats it as a string, not a number.

If the user enters a numeric value into a TextBox and you want to assign that value to a numeric variable, you must convert the control’s Text property to the desired numeric data type.

You cannot use a cast operator to convert a string directly to a numeric type.
