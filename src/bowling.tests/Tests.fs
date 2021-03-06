﻿namespace Bowling.Tests

open Xunit
open FsUnit.Xunit

module SpecificCases =
    
    [<Fact>]
    let ``12 strikes in row`` () =
        let expected = Some 300
        let actual = Bowling.bowlingScore "XXXXXXXXXXXX"
        actual |> should equal expected

    [<Fact>]
    let ``10 times 9 pins and a miss`` () =
        let expected = Some 90
        let actual = Bowling.bowlingScore "9-9-9-9-9-9-9-9-9-9-"
        actual |> should equal expected
