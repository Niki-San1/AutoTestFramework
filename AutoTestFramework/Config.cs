namespace AutoTestFramework
{
    public static class Config
    {
        public static string BaseURL = "https://testing.todorvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string UserID = "Youtube";            //not empty && 5~12
                public static string PasswordLogin = "12345";       //not empty && 5~12
                public static string RepeatPassword = "12345";      //to match
                public static string PasswordRegister = "1234567";  //not empty && 7~12
                public static string Name = "Aaa";                  //alphabet only
                public static string Address = "Aaa2";              //alphanumerical only
                public static string Country = "2";                 //
                public static string ZIPCode = "12345";             //numeric only
                public static string Email = "e@mail.com";          //
            }

            public static class Invalid
            {
                public static class UserID                          //not empty && 5~12
                {
                    public static string Empty = "";
                    public static string FourCharacters = "1234";
                    public static string ThirteenCharacters = "1234567890123";
                }

                public static class PasswordLogin                   //not empty && 5~12
                {
                    public static string Empty = "";
                    public static string FourCharacters = "1234";
                    public static string ThirteenCharacters = "1234567890123";
                }

                public static class RepeatPassword
                {
                    public static string Reverse = "54321";
                }

                public static class PasswordRegister                //not empty && 7~12
                {
                    public static string Empty = "";
                    public static string SixCharacters = "123456";
                    public static string ThirteenCharacters = "1234567890123";
                }

                public static class Name                            //alphabet only
                {
                    public static string Empty = "";
                    public static string Space = "You Tube";
                    public static string Number = "YouTube1";
                    public static string SpecialDot = "YouTube.";
                    public static string SpecialSymbol = "YouTube%";
                }

                public static class Address                         //alphanumerical only
                {
                    public static string Empty = "";
                    public static string Space = "You Tube";
                    public static string Number = "YouTube1";
                    public static string SpecialDot = "YouTube.";
                    public static string SpecialSymbol = "YouTube%";
                }

                public static class Country
                {

                }

                public static class ZIPCode                         //numeric only
                {
                    public static string Empty = "";
                    public static string Space = "12 3";
                    public static string SpecialDot = "123.";
                    public static string SpecialSymbol = "123%";
                }

                public static class Email
                {
                    public static string NoName = "@mail.com";
                    public static string NoAt = "mail.com";
                    public static string NoDomain = "a@mail";
                    public static string WrongDomain = "a@mail.2";
                }
            }
            public static class AlertBoxMessages
            {
                public static string LoginSuccessful = "Succesful login!";
                public static string LoginErrorUserID = "User Id should not be empty / length be between 5 to 12";
                public static string LoginErrorPassword = "Password should not be empty / length be between 5 to 12";
                public static string LoginErrorRepeatPassword = "Passwords do not match!";

                public static string RegisterErrorUserID = "User Id should not be empty / length be between 5 to 12";
                public static string RegisterErrorPassword = "Password should not be empty / length be between 7 to 12";
                public static string RegisterErrorName = "Username must have alphabet characters only";
                public static string RegisterErrorAddress = "User address must have alphanumeric characters only";
                public static string RegisterErrorCountry = "Select your country from the list";
                public static string RegisterErrorZIPCode = "ZIP code must have numeric characters only";
                public static string RegisterErrorEmail = "You have entered an invalid email address!";
            }
        }
    }
}
