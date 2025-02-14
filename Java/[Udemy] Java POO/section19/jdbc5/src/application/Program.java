package application;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.Locale;

import db.DBConnection;
import db.exceptions.DbIntegrityException;

public class Program {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);

		Connection conn = null;
		PreparedStatement pst = null;

		try {
			conn = DBConnection.getConnection();

//			String sqlCommandInsert = "INSERT INTO seller (Name, Email, BirthDate, BaseSalary, DepartmentId) VALUES (?,?,?,?,?)";
//			String sqlCommandInsertTwoValues = "INSERT INTO department (Name) VALUES ('D1'),('D2')";
//			String sqlCommandUpdate = "UPDATE seller SET BaseSalary = BaseSalary + ? WHERE (DepartmentId = ?)";
			String sqlCommandDelete = "DELETE FROM department WHERE Id = ?";
			pst = conn.prepareStatement(sqlCommandDelete);
			
			int departmentId = 5;
			
			pst.setInt(1, departmentId);
			
			int rowsAffected = pst.executeUpdate();
			
			System.out.printf("Rows affected: %d", rowsAffected);
			
		} catch (SQLException e) {
			throw new DbIntegrityException(e.getMessage());
		} finally {
			DBConnection.closeStatement(pst);
			DBConnection.closeConnection();
		}
	}
}