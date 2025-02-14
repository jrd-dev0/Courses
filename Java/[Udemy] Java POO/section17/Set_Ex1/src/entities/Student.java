package entities;

import java.util.Objects;

public class Student {

    private Integer iD;

    public Student(Integer iD) {
        this.iD = iD;
    }

    public Integer getiD() {
        return iD;
    }

    public void setiD(Integer iD) {
        this.iD = iD;
    }

    @Override
    public boolean equals(Object o) {
        if (o == null || getClass() != o.getClass()) return false;
        Student student = (Student) o;
        return Objects.equals(getiD(), student.getiD());
    }

    @Override
    public int hashCode() {
        return Objects.hashCode(getiD());
    }
}
