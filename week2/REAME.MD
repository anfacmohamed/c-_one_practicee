Chapter 2 — Processing Data (C#)

1. Introduction

This chapter explains how to process data in C# Windows Forms applications. It introduces the basic concepts used to receive input from users, store information, perform calculations, convert data types, and display results.

The chapter also explains how to handle errors, use mathematical methods, work with graphical user interface (GUI) controls, and find programming errors through debugging.

2. Reading Input with TextBox Controls

A TextBox is a graphical user interface control that allows users to enter information using the keyboard.

TextBox controls are commonly used to collect information such as names, numbers, addresses, and other user input.

The Text property stores the information entered by the user. This property treats the input as a string, even when the user enters digits.

A TextBox can also be cleared when the application needs to remove the previous input.

Key points:

- A TextBox receives keyboard input.
- The Text property stores the entered information.
- TextBox controls are available in the Toolbox.
- A TextBox can be cleared when necessary.

3. A First Look at Variables

A variable is a named storage location in computer memory. It stores information that a program can use while it is running.

Every variable has a name and a data type. The name identifies the variable, while the data type determines what kind of information it can store.

Variables must be declared before they are used. They can store different kinds of information, including text and numbers.

Variable Naming Rules

- A variable name must begin with a letter or an underscore.
- A variable name cannot contain spaces.
- Reserved keywords cannot be used as variable names.
- Meaningful names should be selected to make programs easier to understand.

Local Variables and Scope

A local variable is declared inside a method. It can only be accessed within the area where it is available.

Scope refers to the part of a program in which a variable can be accessed. The lifetime of a local variable describes how long it exists in memory during program execution.

A local variable must receive a value before it is used.

4. Data Types

A data type specifies the kind of information a variable can hold. Selecting the correct data type is important when storing information and performing calculations.

Common Numeric Data Types

Integer ("int")

Used to store whole numbers without fractional parts.

Double ("double")

Used to store numeric values that can contain fractional parts.

Decimal ("decimal")

Used for numbers requiring greater precision, especially in financial applications.

String ("string")

Used to store text, characters, names, and other combinations of characters.

Numeric Literals

A numeric literal is a number written directly in program code. Whole-number literals are generally treated as integers, while numbers containing a decimal point are generally treated as doubles.

Decimal literals use the letter M or m to identify the decimal type.

Assignment Compatibility

Values assigned to variables must be compatible with their data types. For example, a variable declared as an integer cannot directly store a fractional double value.

Type casting allows a programmer to explicitly convert a value from one data type to another when the conversion is supported.

The "var" keyword can also be used for local variables when an initial value allows the compiler to determine the variable's data type.

5. Performing Calculations

C# supports mathematical calculations through arithmetic operators.

The main arithmetic operators are:

- Addition: combines two values.
- Subtraction: finds the difference between values.
- Multiplication: multiplies values.
- Division: divides one value by another.
- Modulus: returns the remainder after division.

Mathematical expressions follow the normal order of operations. Parentheses can be used to control the order in which calculations are performed.

Integer Division

When two integers are divided, the result is an integer. Any fractional part is discarded.

To obtain a fractional result, a suitable numeric type, such as double, can be used in the calculation.

When calculations involve different numeric data types, the types must be compatible. Some combinations, such as double and decimal in the same arithmetic expression, require conversion before the operation can be performed.

6. Inputting and Outputting Numeric Values

When users enter numbers into a TextBox, the input is stored as text. Before performing mathematical operations, the text must be converted into the appropriate numeric data type.

Parsing

Parsing converts a string containing a valid number into a numeric value.

The chapter introduces three common parsing methods:

- "int.Parse" — converts text into an integer.
- "double.Parse" — converts text into a double.
- "decimal.Parse" — converts text into a decimal.

The input must be in a valid format. If the user enters invalid numeric information, a runtime exception may occur.

Displaying Numeric Values

The Text property of a control accepts text. Therefore, numeric values must be converted to strings before being displayed in controls such as Labels or TextBoxes.

The "ToString()" method converts a value into its text representation.

7. Formatting Numbers with ToString()

The ToString method can format numbers so they appear in a particular way.

The chapter covers these format strings:

- N — Number format: displays a number using number formatting.
- F — Fixed-point format: displays a fixed number of decimal places.
- E — Exponential format: displays a number using exponential notation.
- C — Currency format: displays a number as currency.
- P — Percentage format: displays a value as a percentage.

Formatting makes numerical output easier to read and understand. The format selected depends on the purpose of the information being displayed.

8. Simple Exception Handling

An exception is an unexpected error that occurs while a program is running. Examples include invalid user input, attempting to open a file that does not exist, and dividing by zero in operations where it causes an error.

If an exception is not handled, the application may stop unexpectedly.

Try-Catch

Exception handling allows a program to respond to errors instead of terminating unexpectedly.

The "try" block contains statements that may cause an exception. The "catch" block contains the instructions executed when a matching exception occurs.

An exception can also provide a Message property containing a description of the error.

Exception handling helps make applications more reliable and provides an opportunity to display useful error messages to users.

Throwing and Catching Exceptions

Throwing an exception means an error condition has occurred and an exception has been raised.

Catching an exception means the program responds to the exception through an appropriate handler.

9. Using Named Constants

A named constant is a name representing a value that cannot be changed during program execution.

The "const" keyword is used to declare a constant.

Constants are useful when a program repeatedly uses a value that should remain unchanged. Giving a constant a meaningful name makes its purpose easier to understand.

Writing constant names in uppercase letters is a common convention, although it is not required.

10. Declaring Variables as Fields

A field is a variable declared at the class level, outside individual methods.

Unlike a local variable, a field can be accessed by the appropriate methods within its class, subject to its access restrictions.

A field is created when its containing object or class is initialized, depending on the kind of field.

Fields are useful when information needs to be shared between multiple methods in the same class.

11. Using the Math Class

The .NET Math class provides methods and constants for performing mathematical operations.

The chapter introduces the following methods:

- Math.Sqrt: calculates the square root of a number.
- Math.Pow: raises a number to a specified power.
- Math.Max: returns the greater of two values.
- Math.Min: returns the smaller of two values.
- Math.Round: rounds a number to the nearest integer according to the method's rounding rules.

The chapter also introduces two mathematical constants:

- Math.PI: represents the ratio of a circle's circumference to its diameter.
- Math.E: represents the base of the natural logarithm.

These methods and constants help programmers perform common mathematical calculations without writing the mathematical operations from the beginning.

12. More GUI Details

The chapter introduces additional features of graphical user interface controls in Windows Forms applications.

Focus and Tab Order

Focus identifies the control that currently receives keyboard input.

Tab order determines the sequence in which controls receive focus when the user presses the Tab key.

The TabIndex property indicates a control's position in the tab order. The first position starts at zero.

Access Keys

An access key, also called a mnemonic, allows users to access a control through a keyboard shortcut combined with the Alt key.

An ampersand placed before a letter in a button's Text property can designate that letter as the access key.

Setting Colors

Controls can use background and foreground colors.

- BackColor: specifies a control's background color.
- ForeColor: specifies the color of text displayed by a control.

The available color options include custom colors, web colors, and system colors.

Background Images

A Windows Form can display a background image. The BackgroundImageLayout property controls how the image is positioned or resized.

The available layout options discussed in the chapter are None, Tile, Center, Stretch, and Zoom.

GroupBox and Panel

GroupBox and Panel are container controls that can hold other controls.

A GroupBox can display a title and has a Text property. A Panel does not display a title through a Text property and provides a BorderStyle property for its border.

13. Using the Debugger to Locate Logic Errors

A logic error is a programming mistake that allows an application to run but causes it to produce an incorrect result.

Examples include performing an incorrect calculation, assigning a value to the wrong variable, or assigning an incorrect value.

Debugging tools help programmers identify and correct these errors.

Breakpoints

A breakpoint is a selected line in the source code where program execution pauses when the application reaches that line.

While execution is paused, the programmer can inspect variable values and control properties.

Break Mode

Break mode is the state in which program execution is paused at a breakpoint. It allows the programmer to examine the current program state.

Locals and Watch Windows

The Locals window displays variables available in the current procedure, including their values and data types.

The Watch window allows the programmer to select particular variables or expressions to monitor.

Single-Stepping

Single-stepping executes the program one statement at a time. After each statement, the programmer can inspect values and identify where the program begins to produce an incorrect result.

14. Key Learning Outcomes

After studying this chapter, students should be able to:

- Explain the purpose of variables and data types.
- Identify common numeric data types.
- Read input using TextBox controls.
- Perform basic arithmetic calculations.
- Convert text into numeric values and numbers into strings.
- Format numeric output.
- Explain exception handling using try-catch.
- Describe named constants and class-level fields.
- Identify common methods of the Math class.
- Explain focus, tab order, access keys, and GUI control properties.
- Describe how breakpoints and debugging windows help locate logic errors.

Conclusion

This chapter provides the foundation for processing data in C# Windows Forms applications. It explains how programs receive, store, convert, calculate, and display information. It also introduces error handling, mathematical tools, graphical interface features, and debugging techniques that help programmers create more reliable applications.
