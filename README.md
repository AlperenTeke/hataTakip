### Genel Bakış

Bu proje, boyut, durum, vardiya ve hata kayıtları ile ilgili veri eklemek ve yönetmek için kullanılan 
bir Hata Takip Sistemi olarak tasarlanmıştır. Sistem, kullanıcı dostu bir arayüze sahiptir ve
kimlik doğrulama özelliklerini içerir.

### Kullanım
## Ana Sayfa Formu
Ana sayfa formu yüklenirken "boyut", "durum" ve "vardiya" değerleri ilgili tablolardan comboBox araçlarına yüklenir.
Hata kaydı eklemek için tüm gerekli değerleri doldurun.
Kayıt işlemini gerçekleştirmek için "btn_kaydet" düğmesine tıklayın.

### Boyut Ekleme
Form1 üzerinde "Boyut Ekleme" butonuna tıklayın.
Kullanıcı adı ve şifre doğrulaması yapın.
Doğru giriş yapıldığında, boyut ekleme sayfasına yönlendirilirsiniz.
Boyut ekleme sayfasında, bir metin kutusu, bir datagridview ve boyut eklemek için üç düğme bulunmaktadır.
Veritabanındaki "boyut" tablosuna boyut eklemek için gerekli işlemleri gerçekleştirin.

### Durum Ekleme
Form1 üzerinde "Durum Ekleme" butonuna tıklayın.
Kullanıcı adı ve şifre doğrulaması yapın.
Doğru giriş yapıldığında, durum ekleme sayfasına yönlendirilirsiniz.
Durum ekleme sayfasında, bir metin kutusu, bir datagridview ve durum eklemek için üç düğme bulunmaktadır.
Veritabanındaki "durum" tablosuna durum eklemek için gerekli işlemleri gerçekleştirin.

### Vardiya Ekleme
Form1 üzerinde "Vardiya Ekleme" butonuna tıklayın.
Kullanıcı adı ve şifre doğrulaması yapın.
Doğru giriş yapıldığında, vardiya ekleme sayfasına yönlendirilirsiniz.
Vardiya ekleme sayfasında, bir metin kutusu, bir datagridview ve vardiya eklemek için üç düğme bulunmaktadır.
Veritabanındaki "vardiya" tablosuna vardiya eklemek için gerekli işlemleri gerçekleştirin.

### Veritabanı ve Tablo Oluşturma
## Veritabanı ve tabloları oluşturmak için aşağıdaki SQL kodunu kullanabilirsiniz:

```
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
```
