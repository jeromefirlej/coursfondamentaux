# Le composant Logging

## Objectif:
*	Créer un composant pour loguer les comportements de mon application.

## Énonce :
### 1. Ecrivez un composant Logger, qui aura (au minimum) :
    *	Une interface ILogger définissant les méthodes LogInfo(string message) et LogError(string error)
    *	Une classe Logger implémentant ILogger

Les logs devront être écris dans un fichier `log-jjMMaaaa.log`    
Chaque ligne de log devra être écrit sous la forme `[hh:mm:ss] – type – message` où type vaudra `Info` ou `Error`

Vous pourrez utiliser la fonction `WriteLine` pour écrire vos logs
```csharp
    private void WriteLine(string line)
    {
        bool append = true;
        using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\temp\WriteLines2.txt", append))
        {
            file.WriteLine(line);
        }
    }
```
### 2. Je dois pouvoir configurer mon composant pour pouvoir définir le répertoire de log et le format attendue pour les dates.
   
On utilisera les nuget
```
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.FileExtensions
dotnet add package Microsoft.Extensions.Configuration.Json
```

La configuration sera stocké dans le fichier `appsettings.json` sous la forme
```
{
    "maClef" : "ma valeur"
}
```

On pourra charger la configuration grace au code
```
IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string maClef = config.GetSection("maClef").Value;
```


