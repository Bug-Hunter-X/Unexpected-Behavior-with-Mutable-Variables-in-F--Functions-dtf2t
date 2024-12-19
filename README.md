# F# Mutable Variable Swap Bug

This repository demonstrates a common, yet subtle, error when working with mutable variables and function parameters in F#.

The issue arises from the way F# handles references by default when passing mutable variables to functions.  The example shows an attempt to swap two integer values, which produces unexpected results depending on whether the variables are passed directly or as references.

## Problem

The original code attempts to swap two integer variables using two different functions. While the first functions works as expected, the second doesn't because it passes the variables as references. This is because when you pass references to a function, the function can directly modify the values of the variables outside of the function scope, leading to unexpected side effects. 

## Solution

The solution introduces improved parameter handling in the `swap2` function to correctly swap referenced values by creating copies rather than directly manipulating references to the original variables.

This highlights the importance of understanding how mutable variables and references interact within F# functions.