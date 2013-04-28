package Klase;
import java.util.ArrayList;


public class Kurs {
	String naziv,oznaka;
	double ects;
	ArrayList<Student> studenti;
	ArrayList<Profesor> profesori;

	public Kurs(String n, String o ,double d)
	{
		naziv=n;
		oznaka=o;
		ects=d;
		studenti= new ArrayList<Student>();
		profesori = new ArrayList<Profesor>();
	}
	
	public String dajNaziv()
	{
		return naziv;
	}
	public void setNaziv(String s)
	{
		naziv=s;
	}
	
	public String dajOznaku()
	{
		return oznaka;
	}
	public void setOznaku(String s)
	{
		oznaka=s;
	}
	
	public double dajECTS()
	{
		return ects;
	}
	public void setECTS(double d)
	{
		ects=d;
	}
	
	public ArrayList<Student> dajStudente()
	{
		return studenti;
	}
	public ArrayList<Profesor> dajProfesore()
	{
		return profesori;
	}
	
	public int BrojStudenataNaUniverzitetu()
	{
		return studenti.size();
	}
	public int BrojProfesoraNaUniverzitetu()
	{
		return profesori.size();
	}
	
	public void DodajStudentaNaKurs(Student s)
	{
		studenti.add(s);
	}
	public void DodajProfesoraNaKurs(Profesor p)
	{
		profesori.add(p);
	}
	public void IspisiStudenta_Profesora(int id)
	{
		Student s;
		Profesor p;
		for(int i=0;i<studenti.size();i++)
		{
			s=studenti.get(i);
			if(s.dajID()==id)
			{
				studenti.remove(s);
				break;
			}
		}
		for(int i=0;i<profesori.size();i++)
		{
			p=profesori.get(i);
			if(p.dajID()==id)
			{
				profesori.remove(p);
				break;
			}
		}
	}
}
