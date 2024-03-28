# Tekli �� Par�ac��� � �oklu �� Par�ac��� ve Asenkron Programlama (Single � Multi Threading and Asynchronous Programming)


</br></br>


## Tekli �� Par�ac��� (Single Threading)
___�Tekli �� Par�ac��� (Single Threading)�___ �zetle; bir i�lem bir threadi kullan�rken, ba�ka bir i�lemin ayn� threadi kullanamamas�d�r. 
Di�er i�lemin ayn� threadi kullanabilmesi i�in, mevcut durumda threadi kullanan i�lemin bitmesi gerekir. ��te bu duruma da ___�Tekli �� Par�ac��� (Single Threading)�___ denir.

![SingleThreading](https://github.com/eenesyalcin/fdfd/assets/107759141/20eea127-246a-4d55-9df5-2b257d9202fa)

Yukar�daki �emada ��LEM-1 threadi kullanmaktad�r. ��LEM-2'nin threadi kullanabilmesi i�in ��LEM-1'in bitmesini beklemektedir. ��LEM-1 bittikten sonra ��LEM-2 threadi kullanabilecektir.


</br></br>


## �oklu �� Par�ac��� (Multi Threading)
___�Muti Threading�___ �zetle; bir i�lem ger�ekle�tirilirken di�er bir i�lemin s�rada beklemesi yerine e� zamanl� olarak g�rev yapabilmesi i�in, ba�ka bir threadi kullanmas�na denir.
___��oklu �� Par�ac��� (Multi Threading)�___ kullan�m� s�z konusuyken genellikle verimli bir program elde edilebilmesi i�in thread say�s� 8'i ge�mez. 
E�er thread say�s�ndan fazla i�lem say�s� varsa 8 taneden sonraki i�lemler i�in tekrar ___�Tekli �� Par�ac��� (Single Threading)�___ durumu s�z konusu olur. 
Yani herhangi bir thread bo�a ��kana kadar i�lem bekler ve bir thread bo�a ��kt���nda ger�ekle�tirilmesi gereken i�lem o threade yap���r. 
Ayr�ca toplam 8 taneden olu�an thread k�mesine thread havuzu anlam�na gelen ___��� Par�ac��� Havuzu (Thread Pool)�___ denir.

![MultiThreading](https://github.com/eenesyalcin/fdfd/assets/107759141/1a873bcd-bd1d-481c-9a44-15e1852663e7)

Yukar�daki �emada 9 tane i�lem ve 8 tane thread vard�r. Her thread bir i�lem taraf�ndan kullan�lmaktad�r. Bo�ta olan ��LEM-9, THREAD-7'nin i�ini ilk bitirdi�ini varsayarsak hemen ona yap���r ve 
onu kullanmaya ba�lar. Yani 8 tane ile s�n�rland�r�lm�� olan ___��oklu �� Par�ac��� (Multi Threading)�___ s�z konusu ise, 8. i�lemden sonra bu durum ___�Single Threading (Tekli �� Par�ac���)�___ durumuna d�ner.


</br></br>


## Asenkron Programlama (Asynchronous Programming)
___�Asynchronous Programming (Asenkron Programlama)�___ �zetle; iki i�lemin e� zamanl� olarak ayn� threadi kullanabilmesine denir.

![AsynchronousProgramming](https://github.com/eenesyalcin/fdfd/assets/107759141/540cc976-9c6a-4333-aba1-8b8e71679501)

Yukar�daki �emada ��LEM-1 threadi kullanmaya ba�lam��t�r. E� zamanl� olarak ��LEM-2 de ayn� threadi kullanmaktad�r. 
Ayr�ca ___�Asynchronous Programming (Asenkron Programlama)�___ da iki i�lem ayn� threadi; ayn� zamanda ve ayn� �ekilde(konumda) kullanabilirler.


</br><hr>


E�er yaz�m� Medium hesab�mdan okumak ve destek vermek isterseniz a�a��daki linki ziyaret edebilirsiniz. </br>
***https://medium.com/@eenes.ylcn/single-thrading-multi-threading-ve-asenkron-programlama-306d0d6dbbc1*** <hr>