Error Tracking
Usage
While loading the Main Page Form, values for "size," "status," and "shift" are loaded into the respective comboBox tools from the relevant tables. To add an error record, you can fill in all the values and perform the registration process by clicking the btn_save button.

Adding Size
Click the "Add Size" button on Form1.
Perform username and password authentication.
If the login is successful, you will be redirected to the size addition page.
On the size addition page, there is a textbox, a datagridview, and three buttons for adding size.
Perform the necessary operations to add size to the "size" table in the database.
Adding Status
Click the "Add Status" button on Form1.
Perform username and password authentication.
If the login is successful, you will be redirected to the status addition page.
On the status addition page, there is a textbox, a datagridview, and three buttons for adding status.
Perform the necessary operations to add status to the "status" table in the database.
Adding Shift
Click the "Add Shift" button on Form1.
Perform username and password authentication.
If the login is successful, you will be redirected to the shift addition page.
On the shift addition page, there is a textbox, a datagridview, and three buttons for adding shift.
Perform the necessary operations to add shift to the "shift" table in the database.
Database and Table Creation
-- Create Database
CREATE DATABASE errorTrackingDB;

-- Specify the Database to Use
USE errorTrackingDB;

-- adminUsers Table
CREATE TABLE adminUsers (
id INT PRIMARY KEY AUTO_INCREMENT,
username VARCHAR(255) NOT NULL,
password VARCHAR(255) NOT NULL
);

-- size Table
CREATE TABLE size (
id INT PRIMARY KEY AUTO_INCREMENT,
size VARCHAR(255) NOT NULL
);

-- status Table
CREATE TABLE status (
id INT PRIMARY KEY AUTO_INCREMENT,
status VARCHAR(255) NOT NULL
);

-- shift Table
CREATE TABLE shift (
id INT PRIMARY KEY AUTO_INCREMENT,
shift VARCHAR(255) NOT NULL
);

-- error Table
CREATE TABLE error (
errorNo INT PRIMARY KEY,
date DATE NOT NULL,
stockNo INT NOT NULL,
tireSize VARCHAR(255) NOT NULL,
quantity INT NOT NULL,
errorCode VARCHAR(255) NOT NULL,
status INT NOT NULL,
shift INT NOT NULL
);

Hata Takip
Kullanım
Anasayfa Formu yüklenirken "boyut","durum" ve "vardiya" değerleri ilgili tablolardan comboBox toollarına yüklenir. Hata kaydı eklemek için tüm değerleri doldurup btn_kaydet butonuna tıklayarak kayıt işlemini gerçekleştirebilirsiniz.

Boyut Ekleme
Form1 üzerinde "Boyut Ekleme" butonuna tıklayın.
Kullanıcı adı ve şifre doğrulaması yapın.
Eğer doğru giriş yapılırsa, boyut ekleme sayfasına yönlendirilirsiniz.
Boyut ekleme sayfasında, boyut eklemek için bir textbox, bir datagridview ve üç buton bulunmaktadır.
Veritabanındaki "boyut" adlı tabloya boyut eklemek için gerekli işlemleri gerçekleştirin.
Durum Ekleme
Form1 üzerinde "Durum Ekleme" butonuna tıklayın.
Kullanıcı adı ve şifre doğrulaması yapın.
Eğer doğru giriş yapılırsa, durum ekleme sayfasına yönlendirilirsiniz.
Durum ekleme sayfasında, durum eklemek için bir textbox, bir datagridview ve üç buton bulunmaktadır.
Veritabanındaki "durum" adlı tabloya durum eklemek için gerekli işlemleri gerçekleştirin.
Vardiya Ekleme
Form1 üzerinde "Vardiya Ekleme" butonuna tıklayın.
Kullanıcı adı ve şifre doğrulaması yapın.
Eğer doğru giriş yapılırsa, vardiya ekleme sayfasına yönlendirilirsiniz.
Vardiya ekleme sayfasında, vardiya eklemek için bir textbox, bir datagridview ve üç buton bulunmaktadır.
Veritabanındaki "vardiya" adlı tabloya vardiya eklemek için gerekli işlemleri gerçekleştirin.
Veritabanı Ve Tablo Oluşturma
-- Veritabanı Oluştur
CREATE DATABASE hataTakipDB;

-- Kullanılacak Veritabanı Belirt
USE hataTakipDB;

-- adminUsers Tablosu
CREATE TABLE adminUsers (
id INT PRIMARY KEY AUTO_INCREMENT,
username VARCHAR(255) NOT NULL,
password VARCHAR(255) NOT NULL
);

-- boyut Tablosu
CREATE TABLE boyut (
id INT PRIMARY KEY AUTO_INCREMENT,
boyut VARCHAR(255) NOT NULL
);

-- durum Tablosu
CREATE TABLE durum (
id INT PRIMARY KEY AUTO_INCREMENT,
durum VARCHAR(255) NOT NULL
);

-- vardiya Tablosu
CREATE TABLE vardiya (
id INT PRIMARY KEY AUTO_INCREMENT,
vardiya VARCHAR(255) NOT NULL
);

-- hata Tablosu
CREATE TABLE hata (
hataNo INT PRIMARY KEY,
tarih DATE NOT NULL,
stokNo INT NOT NULL,
lastikBoyut VARCHAR(255) NOT NULL,
adet INT NOT NULL,
hataKodu VARCHAR(255) NOT NULL,
durum INT NOT NULL,
vardiya INT NOT NULL
);
