package com.example.example

import java.lang.ArithmeticException
import java.lang.IllegalArgumentException

fun main()
{
    var input = "bruh"

    while (input != "0")
    {
        print("What part of the example would you like to go to?(0 to exit)")
        input = readLine().toString()
        if (input == "1")
        {
            //part 1 variables and vars
            part1()
        }
        else if (input == "2")
        {
            //part 2 decision structures
            part2()
        }
        else if (input == "3")
        {
            //part 3 loops
            part3()
        }
        else if (input == "4")
        {
            //part 4 collections
            part4()
        }
        else if (input == "5")
        {
            //part 5 classes
            part5()
        }
        else if (input == "6")
        {
            //part 6 lambda expressions
            part6()
        }
        else if (input == "0")
        {
            //exit
            print("Bye bye")
        }
        else
        {
            print("Bruh\n")
        }
    }
}

fun part1()
{
    val x: Int = 3 //val can be manually casted like so. for ints, kinda useless, but good for decimal numbers
    val y: Float = 2f //vals cannot be reassigned. kinda consts but can be assigned once at run, such as from a text box.
    var sum = x + y //vars can be reassigned
    val z: Int = 1 //val always assigns the larger data type, exe. 2.0 is stored as a double instead of float
    sum += z

    val name = "Westone" //vals take up less ram than vars
    val initial = 'M' //assumes char
    sum++ //increment and decrement work as expected
    sum--

    val isTrue = true //bools function as expected

    print("$name's sum is: $sum\n")

}

fun part2()
{
    val score1 = 75
    val score2 = 95

    if (score1 > score2) //can be done without braces if only one line is needed after each condition
    {
        print("Score 1 is greater than score 2.\n")
    }
    else if (score1 < score2)
    {
        print("Score 1 is less than score 2.\n")
    }
    else
    {
        print("Score 1 is equivalent to score 2.\n")
    }

    //when statements are the same as switch statements, but doesn't need breaks
    when (score1) //like if elses, can be done without braces if only one statement
    {
        is Int-> print("$score1 is an integer.\n")
        60,65 -> print("Student is not doing so well.") //checks multiple values
        in 70..79-> //checks a range
        {
            print("Score is a C")
        }
        85->
        {
            print("Score is 85")
        }
        95->
        {
            print("Score is 95")
            print("Student receives an A.")
        }
        else->print("Student score could not be read.") //default statement
    }
}

fun part3()
{
    //while
    var counter = 1
    while (counter <= 10)
    {
        print("Counter: $counter\n")
        counter++
    }

    //do while
    var count = 1
    do {
        print("Do Counter: $count\n")
        count++
    } while (count < 10)

    //for
    //step controls how much is incremented or decremented
    for (num in 1..10 step 2) //for(int num = 1; num <= 10; num++
    {
        print("Num: $num\n")
    }

    for (num in 1 until 10 step 3) //until is not inclusive
    {
        print("Other Num: $num\n")
    }

    for (num in 10 downTo 1) //inclusive downward count
    {
        print("Downer: $num\n")
    }
}

fun part4()
{
    //arrays cannot be resized, only one data type per array
    val arr = arrayOf(1, 2, 3, 4) //inferred value of int
    //val arr1: IntArray = intArrayOf(1,2,3,4) other way of writing ^
    val arrInt = intArrayOf(1,2,3,4) //explicitly an int
    val arrDouble = doubleArrayOf(1.0,2.0,3.0,4.0) //explicitly double

    print(arr[2])
    arr[2] = 5
    print(arr[2])

    //lists can be resized and can have multiple data types. can be printed straight out
    val lis = listOf(1,2,3,4,"Monday","Tuesday", true, false).toMutableList() //allows for resizability
    //val newLis = lis.toMutableList() //creates a copy of list with mutability
    print(lis.size)
    val addLis = listOf(5,6,7)
    lis.addAll(addLis)
    print(lis)

    lis.add("Wednesday")
    print(lis)

    //sets no duplicates, can sort, immutable
    val days = setOf("Monday","Tuesday","Wednesday","Monday").toMutableSet()
    //.toMutableList() can be used but converts to list
    print(days.toSortedSet())
    days.add("Thursday") //addAll can be used by creating another set and adding it in between the ()
    print(days)

    //maps key/value pairs. also called dictionaries and hashmaps
    val daysMap = mapOf(1 to "Monday", 2 to 0, 3 to true).toMutableMap() //what is printed below will be changed depending on what order the keys are in
    for (key in daysMap.keys) //keys don't have to be integers, can be strings, ints, ect.
    {
        print("$key calls ${daysMap[key]}\n")//wrap in curly braces for when substituting non-hardcoded string in prints
    }

    daysMap[4] = "Thursday"
    daysMap[5] = "Friday"

    for (key in daysMap.keys)
    {
        print("$key calls ${daysMap[key]}\n")
    }

    //arrayLists Dynamic arrays like vector?
    val arrLst = ArrayList<Int>()
    arrLst.add(1)
    arrLst.add(2)
    for(i in arrLst)
    {
        print("$i\n")
    }
    arrLst.get(1)
    arrLst.remove(1)
    arrLst.clear()
    arrLst.addAll(arr) //can add lists and arrays, but they all have to be of the same data type

    val iter = arrLst.iterator()

    while(iter.hasNext())
    {
        print(iter.next())
    }
}

fun part5()
{
    val gobta = Goblin("Gobta", "Wolf Rider")
    //println("${gobta.name}")
    val gobto = Goblin("Gobto")
    val bogtu = Goblin("Gobtu", "Berserker", "Axe")

    gobto.changeName("Gobti")
    //gobto.name = "Gobti" gets blocked by the private nature of the setter
}

class Goblin(gname:String, gjob:String = "Commoner") //different var names so they arent the same in the init, can be assigned default values
{
    //constructor(name:String, job:String) constructor can be declared here but is more common in class declaration^
    //member variables
    var name: String? = null //question mark makes variable allow nulls
        private set(value)//error catching for classes
        {
            field = if(value != "") value else throw IllegalArgumentException("Name cannot be empty.")
        }
    var job: String? = null
        private set //must be right after the variable declaration to specify what is being modified
    var weapon: String? = null

    init
    {
        name = gname
        job = gjob
        println("A new $job named $name enters the fray!")
    }

    constructor(gname: String, gjob: String, gweapon: String = "Dagger") : this(gname, gjob) //overloaded constructor?
    {
        weapon = gweapon
        println("A new $job named $name wielding a(n) $weapon enters the fray!")
    }

    fun changeName(newName:String)
    {
        name = newName
    }
}

fun part6()
{
    //normal way
    lambdaExe(2,3) //not scoped

    //lambda expression
    val sum = {x:Int, y:Int -> println(x+y)} //scoped
    sum(2,3)
}

fun lambdaExe(x: Int, y:Int)
{
    return try
    {
        println(x+y)
    }
    catch (e: ArithmeticException)
    {
        print("Bruh Moment")
    }

}