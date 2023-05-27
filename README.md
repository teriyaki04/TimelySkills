# TimelySkills
Веб приложение для приема заказоов на доставку

In the appsettings.json file you need to change the connection string
```
"ConnectionStrings": {
    "DefaultConnection": "Server=ServerName;Database=DBName;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  },
```
Instead of ServerName you should write your server name(e.g. DESKTOP-...) and Database=Your database name(e.g. TimelySkillsDB)
