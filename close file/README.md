# File Operations README

A plain-language guide to common file operations.

## Read lines

Reading line by line means opening a file and going through it one line at a time. This is the best choice for large files because only one line is held in memory at once. You can also ask for just a single line, such as the first one.

## Read all lines

Reading all lines loads the whole file into memory as a list, with one entry per line. Each entry usually keeps its trailing newline character. You can also read the whole file as a single block of text instead of a list. This is convenient for small files but not for very large ones.

## Read a block

Reading a block means pulling a fixed-size chunk from the file (for example, a few kilobytes) and repeating until nothing is left. This is the standard approach for binary files and very large files. You can also read a block by line range, such as lines 10 to 20, by skipping ahead and then taking only the lines you need.

## Delete an item

Deleting an item from a file means removing a specific line. Files can't be edited in place this way, so the usual steps are:

1. Read all the lines.
2. Remove the line you don't want (by its position or by matching its content).
3. Write the remaining lines back to the file.

Deleting an item from a list in memory works the same way: remove it by value or by position.

## Delete a file

Deleting a file removes it from disk. First check that the file exists, then remove it. Most languages offer a way to do this safely so that a missing file doesn't cause an error.

> Deleting a file is permanent. Double-check the path before you do it.
