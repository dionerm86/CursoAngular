using Game.Lib;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador1("Dione"), new Jogador2("Otávio"));

            jogo.IniciarJogo();
        }
    }
}

//Adicionar ClasLibrary
//dotnet new classlib -n Game.Lib

//Adicionar Referencia
//dotnet add Game/Game.csproj reference Game.Lib/Game.Lib.csproj

//Adicionar solução sln
//dotnet new sln -n Game

//Adicionar projetos ao sln
//dotnet sln Game.sln add Game/Game.csproj Game.Lib/Game.Lib.csproj
