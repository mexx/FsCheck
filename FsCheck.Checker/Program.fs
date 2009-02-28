﻿#light

open FsCheck
open System

quickCheckAll <| Type.GetType( "FsCheck.Checks.Common, FsCheck", true)

quickCheckAll <| Type.GetType( "FsCheck.Checks.Generator, FsCheck", true)

Console.ReadKey() |> ignore
