package db;

import db.exceptions.DbException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DBConnection {
	
	private static Connection conn = null;

    private DBConnection() {
    }

    public static Connection getConnection() {
    	
        if (conn == null) {
        	
            try {
                String url = DBPropertiesLoader.getProperty("db.url");
                String user = DBPropertiesLoader.getProperty("db.user");
                String password = DBPropertiesLoader.getProperty("db.password");

                conn = DriverManager.getConnection(url, user, password);
                
                System.out.println("Conexão com o banco de dados estabelecida com sucesso!");
                
            } catch (SQLException e) {
                throw new DbException(e.getMessage());
            }
        }
        
        return conn;
    }

    public static void closeConnection() {
    	
        if (conn != null) {
        	
            try {
            	
                conn.close();
                
                System.out.println("Conexão com o banco de dados fechada.");
                
            } catch (SQLException e) {
                throw new DbException(e.getMessage());
            }
        }
    }
}