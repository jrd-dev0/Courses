package application;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Locale;

import db.DBConnection;
import db.exceptions.DbException;

public class Program {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);

		Connection conn = null;
		PreparedStatement pst = null;

		try {
			conn = DBConnection.getConnection();

			String sqlCommand = "INSERT INTO seller (Name, Email, BirthDate, BaseSalary, DepartmentId) VALUES (?,?,?,?,?)";
			pst = conn.prepareStatement(sqlCommand, Statement.RETURN_GENERATED_KEYS);

			String name = "Carl Purple";
			String email = "carl@gmail.com";
			LocalDate birthDate = LocalDate.parse("22/04/1985", DateTimeFormatter.ofPattern("dd/MM/yyyy"));
			double baseSalary = 3000.00;
			int departmentId = 1;

			pst.setString(1, name);
			pst.setString(2, email);
			pst.setObject(3, birthDate);
			pst.setDouble(4, baseSalary);
			pst.setInt(5, departmentId);

			int rowsAffected = pst.executeUpdate();
			
			if(rowsAffected > 0) {
				ResultSet generatedKeys = pst.getGeneratedKeys();
                while (generatedKeys.next()) {
                    System.out.println("New seller ID: " + generatedKeys.getInt(1));
                }
                generatedKeys.close();
			}
			System.out.println("Linhas afetadas: " + rowsAffected);
		} catch (SQLException e) {
			throw new DbException(e.getMessage());
		} finally {
			DBConnection.closeStatement(pst);
			DBConnection.closeConnection();
		}
	}
}