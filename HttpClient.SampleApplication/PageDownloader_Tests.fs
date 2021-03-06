﻿module PageDownloader_Tests

open System
open NUnit.Framework
open FsUnit
open HttpClient
open HttpClient.SampleApplication

[<Test>]
let ``countWordInstances counts the number of times a word is repeated at a given URL`` () =

    let fakeGetResponseBodyFunction request =
        "hi world hi hi hello hi ciao hi"

    let downloader = new PageDownloader( fakeGetResponseBodyFunction )
    downloader.countWordInstances "hi" "some url"
    |> should equal 5