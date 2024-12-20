package com.stringgen.domain;

import java.util.Random;

//Implements IStringGenerator to produce a random string from a given character set.
public class StringGenerator implements IStringGenerator {

    //Generates a random string using a Random generator and the provided characterSet.
    @Override
    public String generateString(String characterSet, int length) {
        Random random = new Random();
        StringBuilder sb = new StringBuilder(length);

        for (int i = 0; i < length; i++) {
            int index = random.nextInt(characterSet.length());
            sb.append(characterSet.charAt(index));
        }

        return sb.toString();
    }
}
