using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

// check git current username & email
// ---
// git config --list

// change config
// ---
// git config --global user.name "Nama"
// git config --global user.email "email"
// git config --global credential.username "username"

// bermain git
// ---
// git init
// git add README.md
// git commit -m "first commit"
// git remote add origin https://github.com/ikamuliana/OCBC-BATCH2-CSHARP.git
// git remote set-url origin git@github.com:ikamuliana/OCBC-BATCH2-CSHARP.git
// git checkout -b main
// git pull origin main --allow-unrelated-histories
// git push -u origin main
//git remote set-url origin git@github.com:ikamuliana/OCBC-BATCH2-CSHARP.git