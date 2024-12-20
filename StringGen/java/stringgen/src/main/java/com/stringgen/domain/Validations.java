package com.stringgen.domain;

//Provides validation methods, such as checking the length of the string.
public class Validations {
    // Checks if the requested length is between 1 and 1000.
    public static boolean isValidLength(int length) {
        return length > 0 && length <= 1000;
    }
}
