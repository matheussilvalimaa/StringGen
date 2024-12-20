package com.stringgen;

import java.util.Scanner;

import com.stringgen.application.StringGenerationService;


public class Main {
    @SuppressWarnings("ConvertToTryWithResources")
    public static void main(String[] args) {
        StringGenerationService stringGen = new StringGenerationService();
        boolean end = true;

        Scanner scanner = new Scanner(System.in);

        System.out.println("=== StringGen - Your favorite string generator! ===");
        while (end){
            String line = "Choose character set (1-5):" +
            " (1) Uppercase"  +
            " (2) Lowercase"+
            " (3) Digits" +
            " (4) Upper + Lower + Digits" +
            " (5) Upper + Lower + Digits + Simbols";
            System.out.println(line);
            int option = Integer.parseInt(scanner.nextLine());
            System.out.println("Enter string length:");
            int length = Integer.parseInt(scanner.nextLine());

            try {
                String result = stringGen.generateAndSaveString(option, length);
                System.out.println("Generated string: " + result);
                System.out.println("Want to generate more? (y/n): ");
                String answer = scanner.nextLine();
                if (answer.equals("y")){
                    continue;
                }
                break;
            } catch (Exception e) {
                System.out.println("Error: " + e.getMessage());
            }
        }
        scanner.close();
    }
}
