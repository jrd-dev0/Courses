import java.util.Locale;
import java.util.Scanner;

public class BEE1061 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] DiaInicio = sc.nextLine().split(" ");
        int diaInicio = Integer.parseInt(DiaInicio[1]);

        String[] horarioInicio = sc.nextLine().split(" : ");
        int horaInicio = Integer.parseInt(horarioInicio[0]);
        int minutoInicio = Integer.parseInt(horarioInicio[1]);
        int segundoInicio = Integer.parseInt(horarioInicio[2]);

        String[] DiaFim = sc.nextLine().split(" ");
        int diaFim = Integer.parseInt(DiaFim[1]);
        
        String[] horarioFim = sc.nextLine().split(" : ");
        int horaFim = Integer.parseInt(horarioFim[0]);
        int minutoFim = Integer.parseInt(horarioFim[1]);
        int segundoFim = Integer.parseInt(horarioFim[2]);

        int dia = 0;
        int hora = 0;
        int minuto = 0;
        int segundo = 0;

        if (diaInicio <= diaFim) {
            dia = diaFim - diaInicio;
        } else {
            dia = 30 - diaInicio + diaFim;
        }

        if (horaInicio <= horaFim) {
            hora = horaFim - horaInicio;
        } else {
            hora = 24 - horaInicio + horaFim;
            dia--;
        }

        if (minutoInicio <= minutoFim) {
            minuto = minutoFim - minutoInicio;
        } else {
            minuto = 60 - minutoInicio + minutoFim;
        }

        if (segundoInicio <= segundoFim) {
            segundo = segundoFim - segundoInicio;
        } else {
            segundo = 60 - segundoInicio + segundoFim;
        }
        
        System.out.println(dia + " dia(s)");
        System.out.println(hora + " hora(s)");
        System.out.println(minuto + " minuto(s)");
        System.out.println(segundo + " segundo(s)");

        sc.close();
    }
}