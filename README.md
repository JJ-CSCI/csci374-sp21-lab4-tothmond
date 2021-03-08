# Lab 4: Recursion

## Problems

In this lab, you will write recursive functions.

**!!! DO NOT USE LOOPS, MUTABLE VARIABLES, PATTERN MATCHING OR ANY LIBRARY FUNCTIONS. ONLY RECURSION IS ALLOWED !!!**
- Allowed library functions: `List.head`, `List.tail`, `List.isEmpty`

### Problem 1

Write a recursive function `prod: (lst:int list) -> int` that returns a product of the elements in the integer list.

### Problem 2

Write a recursive function `map: (f:(int -> 'a) -> int list -> 'a list)` that returns a new list whose elements are the results of applying the given function `f` to each of the elements of the integer list.

### Problem 3

Write a recursive function `odd: int list -> int list` that returns a new list containing only odd elements of the original integer list.

### Problem 4

Write a recursive function `filter: (f:(int -> bool) -> int list -> int list)` that returns a new list containing only the elements of the list for which the given predicate function `f` returns `true`.

## Test

Press **Run** button to execute and test your program.

- Or run `make test` command in the command line to verify the correctness of your program.

## Submission

- Commit & push all changes that to the corresponding assignment repository on GitHub, using the **Repl.it** interface - **Version control** tab.
  - Make sure that you committed changes to following files:
    - `main.fs`
- Submit the link of the assignment GitHub repository in the corresponding assignment submission the Blackboard.
  - Open corresponding assignment on the Blackboard
  - In **Assignment Submission** section, press **Write Submission** button
  - Paste your assignment repository link in the **Text Submission** box
  - Submit the assignment

### Before You Submit

You are required to test that your submission works properly before submission. Make sure that your program compiles without errors. Once you have verified that the submission is correct, you can submit your work.

### Coding Style

In any programming project, matching the existing coding style is important. Having different coding styles intermixed leads to confusion and bugs. Students are required to follow the particular existing coding style that maintains the indentation style in `.fs` and `.fsx` files using spaces, not tabs.

In particular, pay close attention to function declarations and how the function name begins the line after the function return type. For helper functions which are limited in scope to a specific file, you must declare the function as `static` in the same file in which it is used.

*Indentation*: The indentation style for your work have to be 4 spaces. Many students are taught to use tabs for indentation, which can make code very hard to read, especially when there are several levels of indentation.

For additional information, see [F# style guide](https://docs.microsoft.com/en-us/dotnet/fsharp/style-guide/) or [A comprehensive guide to F# Formatting Conventions](https://github.com/fsprojects/fantomas/blob/master/docs/FormattingConventions.md)
