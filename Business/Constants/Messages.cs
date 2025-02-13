﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarNameInvalid = "Araba ismi en az 3 harf olmalıdır.";
        public static string CarPriceInvalid = "Arabanın fiyatı sıfır(0)'dan büyük olmalıdır.";
        public static string CarMaintenanceTime = "Sistem bakımda!";
        public static string RentalReturnDate = "Araba teslim edilmedi.";
        public static string CountOfImageError = "Bir arabanın en fazla 5 adet resmi olabilir.";
        public static string NoCarImageError = "Arabaya ait resim bulunmamaktadır.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError =" Şifre hatalıdır.";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı.";
        public static string UserAlreadyExists ="Kullanıcı zaten mevcut bulunmaktadır.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string CarNotAvailable = "Araba kiralanmış";
        public static string PaymentSuccessful = "Ödeme işlemi başarılı";
        public static string RentalSuccessful = "Kiralama işlemi başarılı";
        public static string CreditCardNotValid = "Kredi kartı mevcut değil";
        public static string StringMustConsistOfNumbersOnly = "Lütfen yalnızca sayı kullanınız.";
        public static string CustomerCreditCardIsAvailable = "Kayıt etmek istediğiniz kredi kartı zaten sistemde kayıtlı bulunmaktadır";
        public static string CreditCardIsNotValidInSaved = "Kredi kartı kayıtlı kartlarınız arasında mevcut değil.";
        public static string CarIsNotRentable = "Seçtiğiniz tarihler arasında kiralanmış olan araç ya da araçlar mevcuttur.";
        public static string CarFindexPointNotToPair = "Findex puanı uyumsuz olan araçlar var. Lütfen sepetinizi kontrol ediniz.";
        public static string TotalAmountError = "Toplam ödemeniz gereken ücret hatalıdır. Lütfen sepetinizi tekrar gözden geçiriniz.";
        public static string CustomerFindexPointNotEnough = "Findex puanınızın yeterli olmadığı araç(lar) mevcuttur.";
        public static string BrandAvailable = "Aynı isimde marka zaten mevcuttur.";
        public static string FindexPointNotAvailable = "Findex puanınız mevcut değil.";
    }
}
