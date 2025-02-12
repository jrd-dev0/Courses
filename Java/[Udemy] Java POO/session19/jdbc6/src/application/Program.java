package application;

import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Locale;

import db.DBConnection;
import db.exceptions.DbException;

public class Program {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);

		Connection conn = null;
		Statement st = null;

		try {
			conn = DBConnection.getConnection();
			conn.setAutoCommit(false); // desativa o modo de commit automático para a conexão.
			st = conn.createStatement();

//			String sqlCommandInsert = "INSERT INTO seller (Name, Email, BirthDate, BaseSalary, DepartmentId) VALUES (?,?,?,?,?)";
//			String sqlCommandInsertTwoValues = "INSERT INTO department (Name) VALUES ('D1'),('D2')";
//			String sqlCommandUpdate = "UPDATE seller SET BaseSalary = BaseSalary + ? WHERE (DepartmentId = ?)";
//			String sqlCommandDelete = "DELETE FROM department WHERE Id = ?";
			String sqlCommand1 = "UPDATE seller SET BaseSalary = 2090 WHERE DepartmentId = 1";
			String sqlCommand2 = "UPDATE seller SET BaseSalary = 3220 WHERE DepartmentId = 2";

			int rowsAffected1 = st.executeUpdate(sqlCommand1);

			// simulando um erro
//			int x = 1;
//			if (x < 2) {
//				throw new DbException("Simulating a program error to test SQL transitions rollback.");
//			}

			int rowsAffected2 = st.executeUpdate(sqlCommand2);

			conn.commit(); // confirma a transação, se todos os comandos forem executados com sucesso.

			System.out.printf("Rows affected: %d%n", rowsAffected1);
			System.out.printf("Rows affected: %d%n", rowsAffected2);

		} catch (SQLException e) {
			try {
				conn.rollback();
				throw new DbException("Transaction rollback. Caused by: " + e.getMessage());
			} catch (SQLException e1) {
				throw new DbException("Transaction rollback failed. Caused by: " + e1.getMessage());
			}

		} finally {
			DBConnection.closeStatement(st);
			DBConnection.closeConnection();
		}
	}
}