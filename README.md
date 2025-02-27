# BluetoothComPort# Arduino Bluetooth Haberleşme Uygulaması

## Açıklama
Bu proje, bir Windows Forms uygulaması ile bir Arduino kartı arasında Bluetooth üzerinden haberleşmeyi sağlar. Uygulama, kullanıcıların Arduino'ya veri göndermesine ve Arduino'dan gelen verileri almasına olanak tanır. Ayrıca, Arduino üzerindeki LED'leri kontrol etmek için fonksiyonlar içerir.

## Kurulum
1. Arduino IDE'yi indirin ve kurun.
2. Bu depodaki `ArduinoBluetooth.ino` dosyasını Arduino IDE ile açın ve Arduino kartınıza yükleyin.
3. Windows Forms uygulamasını Visual Studio ile açın ve çalıştırın.

## Kullanım
1. Uygulamayı başlatın.
2. COM portunu ve baud hızını seçin.
3. "Bağlan" butonuna tıklayın.
4. Göndermek istediğiniz veriyi girin ve "Gönder" butonuna tıklayın.
5. Arduino'dan gelen veriler uygulama arayüzünde görüntülenecektir.
6. LED'leri kontrol etmek için ilgili butonları kullanın.

## English

## Description
This project enables communication between a Windows Forms application and an Arduino board via Bluetooth. The application allows users to send data to the Arduino and receive data from the Arduino. It also includes functions to control LEDs on the Arduino.

## Setup
1. Download and install the Arduino IDE.
2. Open the `ArduinoBluetooth.ino` file from this repository with the Arduino IDE and upload it to your Arduino board.
3. Open and run the Windows Forms application with Visual Studio.

## Usage
1. Start the application.
2. Select the COM port and baud rate.
3. Click the "Connect" button.
4. Enter the data you want to send and click the "Send" button.
5. Data received from the Arduino will be displayed in the application interface.
6. Use the relevant buttons to control the LEDs.
