package application;

import model.entities.Product;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class App {
    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        String sourceFilePath = "C:\\temp\\File.csv";
        File sourceFile = new File(sourceFilePath);
        String sourceFolderStr = sourceFile.getParent();

        // boolean success = new File(sourceFolderStr + "\\out").mkdir();

        // Verifica a criação da pasta e imprime uma mensagem de erro se falhar
        File outFolder = new File(sourceFolderStr + "\\out");
        if (!outFolder.exists() && !outFolder.mkdir()) {
            System.out.println("Erro ao criar o diretório de saída.");
            sc.close();
            return; // Encerra o programa se a criação falhar
        }

        String targetFilePath = String.format("%s\\out\\summary.csv", sourceFolderStr);

        List<Product> list = new ArrayList<>();
        
        try(BufferedReader br = new BufferedReader(new FileReader(sourceFile))){
            String line = br.readLine();
            while(line != null){
                String[] lines = line.split(",");
                String name = lines[0];
                double price = Double.parseDouble(lines[1]);
                int quantity = Integer.parseInt(lines[2]);
                list.add(new Product(name, price, quantity));
                line = br.readLine();

                try(BufferedWriter bw = new BufferedWriter(new FileWriter(targetFilePath))){
                    for(Product p : list){
                        bw.write(String.format("%s, %.2f", p.getName(), p.total()));
                        bw.newLine();
                    }
                }catch(IOException e){
                    System.out.println("Error: " + e.getMessage());
                }
            }
        }catch(IOException e){
            System.out.println("Error: " + e.getMessage());
        } finally {
            sc.close();
        }
    }
}
