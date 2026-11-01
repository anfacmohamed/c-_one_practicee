# Chapter 4 Discussion

This exercise covers how to:

- Repeat code using `while`, `for`, and `do-while` loops
- Add or subtract 1 from a variable with `++` and `--`
- Save data to a file and read it again
- Let the user pick a file using the OpenFileDialog and SaveFileDialog controls
- Produce random numbers
- Run code automatically when a form opens

---

## 1. The while Loop

A `while` loop keeps running a block of code for as long as its condition remains true.

- The variable `count` begins at 0.
- The condition `count < 5` is tested **before** each pass, which makes `while` a pretest loop.
- On every pass, a message box appears and `count` goes up by 1.
- Once `count` hits 5, the loop ends, so "Hello" appears 5 times.

If the condition is already false at the start (for example, `count = 5`), the body never executes.
If nothing changes `count` inside the loop, the condition never becomes false, and the result is an infinite loop.

The screenshot below shows the `while` loop examples.

![While Loop](Screenshots/While_Loop.png)

## 2. Increment and Decrement Operators

The `++` operator raises a variable by 1, and `--` lowers it by 1.

- `count++` is equivalent to `count += 1` and `count = count + 1`.
- `count--` is equivalent to `count -= 1` and `count = count - 1`.

Each operator works in two forms:

- Postfix (`x = count++`): the current value is used first, and the variable is changed afterward. In this case `x` becomes 5 and `count` becomes 6.
- Prefix (`x = ++count`): the variable is changed first, and the updated value is used. Here `count` moves from 6 to 7, so `x` is 7.

The screenshot below shows the increment and decrement examples.

![Increment and Decrement](Screenshots/Increment_Decrement.png)

## 3. The for Loop

A `for` loop keeps the starting value, the test, and the update together on a single line.

Its structure is `for (InitializationExpression; TestExpression; UpdateExpression)`.

- `for (int count = 0; count < 5; count++)` displays "Hello" 5 times, with `count` declared inside the loop itself.
- `for (count = 0; count < 5; count++)` gives the same result, but `count` is declared before the loop.
- `count += 10` makes the loop step up by tens: 0, 10, 20 ... 100.
- `count--` makes the loop count down: 10, 9, 8 ... 0.

The screenshot below shows the `for` loop examples.

![For Loop](Screenshots/For_Loop.png)

## 4. The do-while Loop

A `do-while` loop tests its condition **after** running the body, so the body is guaranteed to run at least once.

- `number` is set to 1.
- A message box displays `1`.
- Next, the condition `number < 0` is evaluated. It is false, so the loop ends.

The same logic written with a `while` loop displays nothing, since the condition is tested before the body.

The screenshot below shows the `do-while` loop example.

![Do While Loop](Screenshots/Do_While_Loop.png)

## 5. Using Files to Store Data

Here, data is saved to a text file and then read back.

### Writing to a file

- `StreamWriter` is the object used to write text into a file.
- `File.CreateText("courses.txt")` makes a new file. If a file with that name already exists, it is replaced.
- `File.AppendText("Names.txt")` adds new lines at the end of an existing file.
- `WriteLine(...)` writes a single line of text.
- `Close()` closes the file and makes sure the data is saved.

### Giving the file location

You can supply a full path rather than just a file name. Placing `@` before the string makes backslashes count as ordinary characters: `@"C:\Data\Names.txt"`.

### Reading from a file

- `StreamReader` is the object used to read text from a file.
- `File.OpenText("students.txt")` opens a file that already exists.
- `while (!inputFile.EndOfStream)` keeps looping until the end of the file is reached. It means the same as `inputFile.EndOfStream == false`.

The screenshot below shows the file examples.

![Files](Screenshots/Files.png)

## 6. OpenFileDialog and SaveFileDialog Controls

Instead of typing a file name, the user selects a file from a dialog box.

- `openFileDialog.ShowDialog()` opens the Open dialog when the button is clicked.
- `ShowDialog()` returns a `DialogResult`: `DialogResult.OK` if the user clicks Open, or `DialogResult.Cancel` if the user cancels.
- `openFileDialog.FileName` stores the chosen file, which can then be passed to `File.OpenText`.
- `openFileDialog.InitialDirectory` sets which folder the dialog opens in.
- `saveFileDialog.ShowDialog()` opens the Save As dialog. If the user clicks OK, `File.CreateText(saveFileDialog.FileName)` creates the file.

The screenshot below shows the dialog examples.

![File Dialogs](Screenshots/File_Dialogs.png)

## 7. Random Numbers

The `Random` class is used to generate random numbers.

- `new Random()` creates the random number generator.
- `rand.Next()` gives back a random integer.
- `rand.NextDouble()` gives back a random decimal from 0.0 up to, but not including, 1.0.
- `rand.Next(100)` gives back a random integer from 0 to 99.

The screenshot below shows the random number examples.

![Random Numbers](Screenshots/Random_Numbers.png)

## 8. The Load Event

The `Form1_Load` event handler runs when the form is loaded into memory.

- Double-clicking the form in the Designer generates an empty `Load` event handler.
- Any code inside it runs before the form is shown.
- In the example, `MessageBox.Show("Prepare to see the form!");` shows a message first.

The screenshot below shows the Load event handler.

![Load Event](Screenshots/Load_Event.png)
