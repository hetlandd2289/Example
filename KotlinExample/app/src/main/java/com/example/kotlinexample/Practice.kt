package com.example.kotlinexample

class Practice {}

fun main()
{
    val arrLst = ArrayList<Int>()
    var lst = listOf(1, 73)

    arrLst.add(1)
    arrLst.add(73)

    println(arrLst)

    println(arrLst.equals(lst))

    println(arrLst.get(1))

    //println(arrLst.indexOf(6))
    val fluffy = Necrohampster("Fluffy", "Attack")
    println(fluffy.name)
}

class Necrohampster (nname: String, ntype: String)
{
    var name: String? = null
    var type: String? = null

    init
    {
        name = nname
        type = ntype

        println("A new $type Necrohapster named $name appears!")
    }
}