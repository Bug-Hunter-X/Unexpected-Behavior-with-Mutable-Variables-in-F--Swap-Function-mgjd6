# F# Mutable Variable Swap Bug

This repository demonstrates a common issue in F# involving mutable variables and unexpected behavior when attempting to swap their values within a function.

The `bug.fs` file contains the buggy code, which incorrectly swaps mutable variables due to F#'s pass-by-value behavior for mutable variables. The `bugSolution.fs` file provides the corrected version, using the `ref` keyword to pass variables by reference and achieve the desired swap operation.

## Bug Description

In F#, mutable variables are passed by value to functions.  This means a copy of the variable's value is passed, not a reference to the variable itself.  The swap function in `bug.fs` modifies these local copies and does not affect the original variables. 

## Solution

The corrected version in `bugSolution.fs` uses the `ref` keyword to pass the variables by reference.  Now modifications within the swap function directly affect the original variables.
