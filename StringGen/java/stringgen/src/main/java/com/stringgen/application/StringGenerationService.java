package com.stringgen.application;

import com.stringgen.domain.CharacterSets;
import com.stringgen.domain.IStringGenerator;
import com.stringgen.domain.StringGenerator;
import com.stringgen.domain.Validations;

//Handles the use case of generating a string and storing it in the database.
public class StringGenerationService {
    
    private final IStringGenerator stringGenerator;

    public StringGenerationService() {
        stringGenerator =  new StringGenerator();
        
    }

    // Generates and saves a string based on the chosen option and length.
    // Validates length before generating, and stores the result in the repository.
    public String generateAndSaveString(int option, int length) {
        if (!Validations.isValidLength(length)) {
            throw new IllegalArgumentException("Invalid length.");
        }

        String characterSet = getCharacterSet(option);
        String generated = stringGenerator.generateString(characterSet, length);

        return generated;
    }

    // Returns the character set based on the user's choice.
    private String getCharacterSet(int option) {
        switch (option) {
            case 1 -> {
                return CharacterSets.UPPERCASE;
            }
            case 2 -> {
                return CharacterSets.LOWERCASE;
            }
            case 3 -> {
                return CharacterSets.DIGITS;
            }
            case 4 -> {
                return CharacterSets.UPPERCASE + CharacterSets.LOWERCASE + CharacterSets.DIGITS;
            }
            case 5 -> {
                return CharacterSets.UPPERCASE + CharacterSets.LOWERCASE + CharacterSets.DIGITS + CharacterSets.SIMBOLS;
            }
            default -> throw new IllegalArgumentException("Invalid option.");
        }
    }
}
