package Klase;
import java.util.ArrayList;


public class Univerzitet {
ArrayList<Student> studenti;
ArrayList<Profesor> profesori;
ArrayList<Administrator> administratori;

public Univerzitet()
{
   studenti = new ArrayList<Student>();
   profesori=new ArrayList<Profesor>();
   administratori=new ArrayList<Administrator>();
}
public ArrayList<Student> dajStudente()
{
	return studenti;
}
public ArrayList<Profesor> dajProfesore()
{
	return profesori;
}
public ArrayList<Administrator> dajAdministratore()
{
	return administratori;
}
public int BrojStudenataNaUniverzitetu()
{
	return studenti.size();
}
public int BrojProfesoraNaUniverzitetu()
{
	return profesori.size();
}
public int BrojAdministratoraNaUniverzitetu()
{
	return administratori.size();
}
public void DodajStudenta(Student s)
{
	studenti.add(s);
}
public void DodajProfesora(Profesor p)
{
	profesori.add(p);
}
public void DodajAdministratora(Administrator a)
{
	administratori.add(a);
}
public void IspisiKorisnika(int id)
{
	Student s;
	Profesor p;
	Administrator a;
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
	for(int i=0;i<administratori.size();i++)
	{
		a=administratori.get(i);
		if(a.dajID()==id)
		{
			administratori.remove(a);
			break;
		}
	}
}
}