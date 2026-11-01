# Discuss Chapter 4: Loops, Files, and Random Numbers

This study guide is based on the Chapter 4 slides of *Starting Out with Visual C#* (Gaddis, Sixth Edition, Global Edition).
The slides are titled Chapter 4 but number their sections 5.1 to 5.9.

This guide explains how to:

- Repeat code with the `while`, `for`, and `do-while` loops
- Increase and decrease variables with `++` and `--`
- Save data in text files and read it back
- Let the user pick a file with the Open and Save dialogs
- Generate random numbers
- Run code when a form loads

---

## 1. The while Loop

In this step, a `while` loop repeats one or more statements for as long as a Boolean expression is true.

- The loop has two parts: the Boolean expression that is tested, and the body, which is the set of statements inside the curly braces.
- The first line is called the while clause.
- Each pass through the body is called an iteration.
- A counter variable keeps track of how many times the loop has run.

The `while` loop is a **pretest loop**, so it tests the condition before every iteration.

- A counter that starts at 0 with the test "less than 5" makes the loop run 5 times.
- If the condition is false from the start, the loop never runs.

An **infinite loop** repeats until the program is interrupted.

- The usual cause is forgetting to change something in the body that would make the condition false, such as never increasing the counter.

![While Loop](Screenshots/While_Loop.png)

## 2. The Increment and Decrement Operators

In this step, a variable is increased or decreased by 1.

- To increment means to increase a value, and to decrement means to decrease it.
- C# provides the `++` and `--` operators for this.
- Adding 1 can be written three ways: `++`, `+= 1`, or the variable equals itself plus 1.
- Subtracting 1 works the same way with `--`, `-= 1`, or the variable equals itself minus 1.

The operators can be placed in two positions:

- **Postfix** (operator after the variable): the old value is used first, then the variable changes.
- **Prefix** (operator before the variable): the variable changes first, then the new value is used.

![Increment and Decrement](Screenshots/Increment_Decrement.png)

## 3. The for Loop

In this step, a `for` loop repeats code a set number of times by using a counter variable.

The loop has three parts:

- **Initialization:** a one-time step that sets the starting value of the counter.
- **Test:** a Boolean expression. If it is true, the loop iterates.
- **Update:** a step that increases or decreases the counter.

Other points to remember:

- Like the `while` loop, the `for` loop is a pretest loop.
- The counter can be declared inside the initialization part or before the loop.
- The update does not have to add 1. It can count by tens or count backward by decrementing.

![For Loop](Screenshots/For_Loop.png)

## 4. The do-while Loop

In this step, a `do-while` loop runs its body first and tests the Boolean expression afterward.

- The `do-while` loop is a **posttest loop**.
- The body always runs at least once, even if the condition is false from the start.
- A `while` loop with the same false condition would not run at all. This difference is the key point to remember.

The table below compares the three loops.

| Loop | Type | Minimum runs | Best used when |
|------|------|--------------|----------------|
| while | Pretest | 0 | The number of repeats is not known in advance |
| for | Pretest | 0 | You need a counter and know how many repeats |
| do-while | Posttest | 1 | The body must run at least once |

![Do While Loop](Screenshots/Do_While_Loop.png)

## 5. Using Files for Data Storage

In this step, a program saves data in a file and reads it later.

Every file task has three steps: **open** the file, **process** it (write to it or read from it), and **close** it.

- Text files store data encoded as text, such as Unicode.
- Binary files store data that is not text and cannot be viewed in a text editor. This chapter only covers text files.
- A file object is tied to one specific file and lets the program work with it.
- .NET provides `StreamWriter` for writing to a text file and `StreamReader` for reading from one.

### Writing to a file

1. Create a `StreamWriter` variable.
2. Open the file with a `File` method:
   - `CreateText` creates the file. If it already exists, its contents are erased.
   - `AppendText` opens the file and adds to the end without erasing what is there.
3. Write the data:
   - `WriteLine` writes the item and then a newline, which ends the line.
   - `Write` writes the item with no newline.
4. Close the file.

### Using a file path

To use a file in another location, give the full path along with the file name. Put the `@` character before the path string so the backslashes are read correctly.

### Reading from a file

1. Create a `StreamReader` variable.
2. Open the file with `File.OpenText`.
3. Read the data:
   - `ReadLine` reads one line and returns it as a string.
   - `Read` reads the next character or set of characters.
   - `ReadToEnd` and `File.ReadAllText` read the whole file at once. The slides list these without further detail.
4. Close the file.

### Reading a whole file with a loop

- A `StreamReader` has a Boolean property called `EndOfStream` that tells you whether the end of the file has been reached.
- A loop that runs while `EndOfStream` is false (or while it is not true) reads every line.

![Files](Screenshots/Files.png)

## 6. The OpenFileDialog and SaveFileDialog Controls

In this step, the user chooses a file with the standard Windows Open and Save As dialog boxes.

- These are invisible controls. When added to a form, they appear in the component tray at the bottom of the Designer, not on the form itself.

### Showing and checking the dialog

- Call the `ShowDialog` method to display the dialog box.
- `ShowDialog` returns a `DialogResult` value that tells you which button the user clicked: `OK` for Open or Save, and `Cancel` if the user cancelled.
- Check this result with an `if` statement before doing anything with the file.

### Useful properties

- `FileName` holds the path and file name the user selected. Use it to open the chosen file.
- `InitialDirectory` sets which folder is shown first when the dialog opens.

### Save As dialog

`SaveFileDialog` works the same way: show it, check for OK, then use the selected file name to create the output file.

![File Dialogs](Screenshots/File_Dialogs.png)

## 7. Random Numbers

In this step, the `Random` class creates random numbers.

First create a `Random` object, then call its methods:

- `Next` produces a random integer. With no argument, it gives a number from 0 up to 2,147,483,647.
- `NextDouble` produces a random floating-point number from 0.0 up to, but not including, 1.0.

To get a number from 0 up to a chosen maximum, pass the maximum plus 1 as the argument. For example, passing 100 gives a number from 0 to 99.

![Random Numbers](Screenshots/Random_Numbers.png)

## 8. The Load Event

In this step, code runs automatically when the form opens.

- When an application runs, its form is loaded into memory and a `Load` event takes place.
- To create a `Load` event handler, double-click the form in the Designer.
- Any code placed in the `Load` event runs when the form is launched. For example, it can show a message box as the form opens.

![Load Event](Screenshots/Load_Event.png)
