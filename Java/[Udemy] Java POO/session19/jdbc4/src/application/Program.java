package application;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
//import java.time.LocalDate;
//import java.time.format.DateTimeFormatter;
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

//			String sqlCommandInsert = "INSERT INTO seller (Name, Email, BirthDate, BaseSalary, DepartmentId) VALUES (?,?,?,?,?)";
//			String sqlCommandInsertTwoValues = "INSERT INTO department (Name) VALUES ('D1'),('D2')";
			String sqlCommandUpdate = "UPDATE seller SET BaseSalary = BaseSalary + ? WHERE (DepartmentId = ?)";
			pst = conn.prepareStatement(sqlCommandUpdate);
			
			double increaseSalary = 200.0;
			int departmentId = 2;
			
			pst.setDouble(1, increaseSalary);
			pst.setInt(2, departmentId);
			
			int rowsAffected = pst.executeUpdate();
			
			System.out.printf("Rows affected: %d", rowsAffected);
			
		} catch (SQLException e) {
			throw new DbException(e.getMessage());
		} finally {
			DBConnection.closeStatement(pst);
			DBConnection.closeConnection();
		}
	}
}