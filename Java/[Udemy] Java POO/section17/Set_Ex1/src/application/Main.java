package application;

import entities.Student;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        List<Student> listA = new ArrayList<>();
        List<Student> listB = new ArrayList<>();
        List<Student> listC = new ArrayList<>();

        System.out.print("How many students for course A? ");
        int n = sc.nextInt();

        for(int i = 0; i < n; i++){
            listA.add(sc.NextInt());
        }

        System.out.print("How many students for course B? ");
        for(int i = 0; i < n; i++){
            listA.add(sc.NextInt());
        }

        System.out.print("How many students for course B? ");
        for(int i = 0; i < n; i++){
            listA.add(sc.NextInt());
        }



    }
}