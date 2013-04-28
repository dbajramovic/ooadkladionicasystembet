package Klase;
import java.util.Date;


public class Osoba {
	int id;
	String ime, prezime,korisnicko_ime,sifra,jmbg,mail,telefon,adresa, ime_oca, prezime_oca, ime_majke, prezime_majke,mjesto_rodjenja,drzava_rodjenja,nacionalnost,drzavljanstvo;
	Date datum_rodjenja;
	Osoba() {};
	public Osoba (String ki, String s,int j,String i, String p,String jmb,String m,String t, String a,String io, String po, String im, String pm, Date dr, String mr,String drzr, String n, String d)
	{
		korisnicko_ime=ki;
		sifra=s;
		id=j;
		ime=i;
		prezime=p;
		jmbg=jmb;
		mail=m;
		telefon=t;
		adresa=a;
		ime_oca=io;
		prezime_oca=po;
		ime_majke=im;
		prezime_majke=pm;
		datum_rodjenja=dr;
		mjesto_rodjenja=mr;
		drzava_rodjenja=drzr;
		nacionalnost=n;
		drzavljanstvo=d;	
	}
	public String dajKorisnickoIme()
	{
		return korisnicko_ime;
	}
	public void setKorisnickoIme(String ki )
	{
		korisnicko_ime=ki;
	}
	public String dajSifru()
	{
		return sifra;
	}
	public void setSifru(String s )
	{
		sifra=s;
	}
	public int dajID()
	{
		return id;
	}
	public void setID(int i )
	{
		id=i;
	}
	public String dajIme()
	{
		return ime;
	}
	public void setIme(String i )
	{
		ime=i;
	}
	public String dajPrezime()
	{
		return prezime;
	}
	public void setPrezime(String p)
	{
		prezime=p;
	}
	public String dajMail()
	{
		return mail;
	}
	public void setMail(String m)
	{
		mail=m;
	}
	public String dajTelefon()
	{
		return telefon;
	}
	public void setTelefon(String t)
	{
		telefon=t;
	}
	public String dajAdresu()
	{
		return adresa;
	}
	public void setAdresu(String a)
	{
		adresa=a;
	}
	public String dajImeOca()
	{
		return ime_oca;
	}
	public void setImeOca(String io )
	{
		ime_oca=io;
	}
	public String dajPrezimeOca()
	{
		return prezime_oca;
	}
	public void setPrezimeOca(String po)
	{
		prezime_oca=po;
	}
	public String dajImeMajke()
	{
		return ime_majke;
	}
	public void setImeMajke(String im )
	{
		ime_majke=im;
	}
	public String dajPrezimeMajke()
	{
		return prezime_majke;
	}
	public void setPrezimeMajke(String pm)
	{
		prezime_majke=pm;
	}
	public Date dajDatumRodjenja()
	{
		return datum_rodjenja;
	}
	public void setDatumRodjenja(Date dr)
	{
		datum_rodjenja=dr;
	}
	public int DajDanRodjenja()
	{
		return datum_rodjenja.getDate();
	}
	public int DajMjesecRodjenja()
	{
		return datum_rodjenja.getMonth();
	}
	public int DajGodinuRodjenja()
	{
		return datum_rodjenja.getYear();
	}
	public String dajMjestoRodjenja()
	{
		return mjesto_rodjenja;
	}
	public void setMjestoRodjenja(String mr)
	{
		mjesto_rodjenja=mr;
	}
	public String dajDrzavuRodjenja()
	{
		return drzava_rodjenja;
	}
	public void setDrzavuRodjenja(String d)
	{
		drzava_rodjenja=d;
	}
	public String dajNacionalnost()
	{
		return nacionalnost;
	}
	public void setNacionalnost(String n)
	{
		nacionalnost = n;
	}
	public String dajDrzavljanstvo()
	{
		return drzavljanstvo;
	}
	public void setDrzavljanstvo(String d)
	{
		drzavljanstvo=d;
	}
}
