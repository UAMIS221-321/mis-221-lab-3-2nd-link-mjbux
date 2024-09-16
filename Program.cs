// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

//main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGamesRecommendation (stadium);
DisplayStadiumDetails(stadium, game);
//end main

static string GetEnjoymentLevel(){
    System.Console.WriteLine("What is your desired enjoyment level?");
    string enjoymentLevel = Console.ReadLine();
    return enjoymentLevel;
}

static string GetStadiumRecommendation(string enjoymentLevel){
    if( (enjoymentLevel =="boring")){
        return "neyland stadium";
    }
    else if ((enjoymentLevel == "average")){
        return "jordan-hare stadium";
    }
    else if((enjoymentLevel == "fun")){
        return "tiger stadium";
    }
    else if((enjoymentLevel == "epic")){
        return "saban field at bryant-denny stadium";   
    }
    else{
        return "that is not a enjoyment level";
    }
}

static string GetGamesRecommendation(string stadium){
    if((stadium =="neyland stadium")){
        return "vs Kent State";
    }
    else if((stadium == "jordan-hare stadium")){
        return "vs Kentucky";
    }
    else if((stadium == "tiger stadium")){
        return "vs Alabama";
    }
    else if((stadium == "saban field at bryant-denny stadium")){
        return "vs Auburn";
    }
    else{
        return "no games match your stadium choice";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine($"based on your excitment level, the best stadium for you to go is {stadium}, with your team playing {game}." );
}
