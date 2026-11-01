# Discuss Chapter 3: Making Decisions in C#

This practice demonstrates how to:

- Run code only when a condition is true with the `if` statement
- Choose between two paths with the `if-else` statement
- Check several conditions with nested `if` statements
- Combine conditions with the logical operators `&&`, `||`, and `!`
- Convert and validate user input with `TryParse`

Each section shows a screenshot of the code, followed by a line-by-line explanation.

---

## 1. The If Statement

In this step, the `if` statement runs a block of code only when a condition is true.

The following screenshot shows the syntax and an example.

![If Statement](Screenshots/If_Statement.png)

**Syntax (lines 1–4)**

- `if (condition)` starts the decision. The condition is a Boolean expression that is either `true` or `false`.
- The code between the curly braces `{ }` runs only when the condition is true.
- If the condition is false, the block is skipped and the program continues with the next statement.

**Example (lines 6–14)**

- Line 6: `sales` is created and set to 60000.
- Line 7: `bonus` is created and set to 0.
- Line 9: `if (sales > 50000)` checks whether sales are greater than 50000. This is true.
- Line 11: because the condition is true, `bonus` is set to 500.
- Line 14: `MessageBox.Show("Bonus: " + bonus);` joins the text and the value, and displays **Bonus: 500**.

If `sales` were 40000, the block would be skipped and the message would show **Bonus: 0**.

## 2. The If-Else Statement

In this step, the `if-else` statement chooses between two paths: one when the condition is true and one when it is false.

The following screenshot shows the syntax and an example.

![If-Else Statement](Screenshots/If_Else_Statement.png)

**Syntax (lines 1–8)**

- The `if` block runs when the condition is true.
- The `else` block runs when the condition is false.
- Exactly one of the two blocks always runs.

**Example (lines 10–19)**

- Line 10: `score` is set to 75.
- Line 12: `if (score >= 50)` checks whether the score is 50 or more. This is true.
- Line 14: the program displays **You Passed!**
- Line 18: the `else` block would display **You Failed!** if the score were below 50.

## 3. Nested Decision Structures

In this step, one `if` statement is placed inside another so the program can check more than one condition.

The following screenshot shows the syntax and a loan example.

![Nested If](Screenshots/Nested_If.png)

**Syntax (lines 1–15)**

- `condition1` is checked first.
- `condition2` is checked only if `condition1` is true.
- The outer `else` runs when `condition1` is false.
- The inner `else` runs when `condition1` is true but `condition2` is false.

**Example (lines 17–34)**

- Lines 17–18: `salary` is 3000 and `yearsOnJob` is 3.
- Line 20: the outer `if` checks `salary >= 2500`. This is true, so the program goes inside.
- Line 22: the inner `if` checks `yearsOnJob >= 2`. This is also true.
- Line 24: the program displays **You qualify for the loan.**
- Line 28: if the years are too low, it displays **Minimum years not met.**
- Line 33: if the salary is too low, it displays **Minimum salary not met.**

## 4. Logical Operators

In this step, logical operators connect two or more conditions in a single `if` statement.

| Operator | Name | Result |
|----------|------|--------|
| `&&` | AND | True only when both conditions are true |
| `\|\|` | OR | True when at least one condition is true |
| `!` | NOT | Reverses true to false and false to true |

The following screenshot shows an example of each operator.

![Logical Operators](Screenshots/Logical_Operators.png)

**AND (lines 1–4)**

- `temperature < 20 && minutes > 12` is true only when the temperature is below 20 **and** the minutes are above 12.
- If either part is false, the message is not shown.

**OR (lines 6–9)**

- `temperature < 20 || temperature > 100` is true when the temperature is below 20 **or** above 100.
- Only one of the two parts has to be true.

**NOT (lines 11–14)**

- `!(temperature > 100)` reverses the result of the condition inside the parentheses.
- The message "The temperature is below the maximum." is shown when `temperature > 100` is false.

## 5. TryParse and Input Validation

In this step, the program converts text typed by the user into a number and then checks that the number is acceptable.

The following screenshot shows the syntax and the full example.

![TryParse and Input Validation](Screenshots/TryParse_Validation.png)

**Syntax (line 1)**

- `int.TryParse(input, out variable)` tries to convert `input` into an integer.
- It returns `true` if the conversion works and `false` if it fails.
- The converted number is stored in `variable` through the `out` keyword.

**Example (lines 3–19)**

- Line 3: `hours` is declared to hold the converted number.
- Line 5: `int.TryParse(txtHours.Text, out hours)` tries to convert the text in the `txtHours` TextBox. If the user typed letters, it returns false and no exception occurs.
- Line 7: the inner `if` validates the number: `hours > 0 && hours <= 168`.
- Line 9: if the number is in range, the program displays **Valid Hours**.
- Line 13: if the number is out of range, the program displays **Invalid Hours**.
- Line 18: if the conversion failed, the program displays **Enter a valid number**.

**TryParse versus validation**

- `TryParse` checks whether the text *can be converted* to a number.
- Validation checks whether the number is *acceptable*. For example, 999 converts successfully, but it is not a valid number of working hours in one week.

---

## Summary

| Topic | Main Purpose |
|-------|--------------|
| If Statement | Executes code when a condition is true |
| If-Else Statement | Chooses between two execution paths |
| Nested If | Checks multiple conditions |
| Logical Operators | Combines or reverses conditions |
| TryParse and Validation | Checks data conversion and input validity |
