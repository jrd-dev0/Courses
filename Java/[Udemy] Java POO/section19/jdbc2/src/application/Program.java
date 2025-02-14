package application;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import db.DBConnection;

public class Program {

	public static void main(String[] args) {
		
        Connection conn = null;
        Statement st = null;
        ResultSet rs = null;
        
        try {
        	conn = DBConnection.getConnection();
        	st = conn.createStatement();
        	rs = st.executeQuery("SELECT * FROM department");
        	
        	while (rs.next()) {
                System.out.printf("%d, %s%n", rs.getInt("Id"), rs.getString("Name"));
            }
        }
        catch (SQLException e) {
			e.printStackTrace();
		}
        finally {
        	DBConnection.closeResultSet(rs);
            DBConnection.closeStatement(st);
            DBConnection.closeConnection();
		}
	}
}