//------------------------------
//   DO NOT MODIFY THIS FILE
//------------------------------
module Test

open System
open Expecto
open Expecto.Impl
open Expecto.Logging
open Expecto.Logging.Message
open Assignment

let tests =
  testList "Tests" [
    testCase "p1" (fun () ->
        Expect.equal (prod [1;2;3]) 6 "prod [1;2;3] = 6"
        Expect.equal (prod [1..10]) 3628800 "prod [1..10] = 3628800"
        Expect.equal (prod []) 1 "prod [] = 1"
    );
    testCase "p2" (fun () ->
        Expect.equal (map (fun x->x+1) [1;2;3]) [2;3;4] "map (fun x->x+1) [1;2;3] = [2;3;4]"
        Expect.equal (map char [71;72;73]) ['G';'H';'I'] "map char [71;72;73] = ['G';'H';'I']"
        Expect.equal (map string []) [] "map string [] = []"
    );
    testCase "p3" (fun () ->
        Expect.equal (odd [1;2;3;4;5]) [1;3;5] "odd [1;2;3;4;5] = [1;3;5]"
        Expect.equal (odd [100..104]) [101;103] "odd [100..104] = [101;103]"
        Expect.equal (odd []) [] "odd [] = []"
        Expect.equal (odd [2;4;6]) [] "odd [2;4;6] = []"
    );
    testCase "p4" (fun () ->
        Expect.equal (filter (fun x-> x>3) [1;2;3;4;5]) [4;5] "filter (fun x-> x>3) [1;2;3;4;5] = [4;5]"
        Expect.equal (filter (fun x-> x>10) [1;2;3;4;5]) [] "filter (fun x-> x>10) [1;2;3;4;5] = []"
        Expect.equal (filter (fun x-> x>1) []) [] "filter (fun x-> x>1) [] = []"
    );
  ]

[<EntryPoint>]
let main args =
  let customFail = { TestPrinters.defaultPrinter with
                        failed = fun n m d ->
                            let lines = m.Split('\n')
                            let res = Array.tryFindIndex (fun (s:string) -> s.Contains("tests.fs")) lines
                            let i = if res.IsNone then 3 else res.Value
                            let newmsg = lines.[0..i] |> Array.fold (fun r s -> r + s + "\n") ""
                            async {
                              do! logger.log LogLevel.Error (
                                    eventX "{testName} failed in {duration}. {message}"
                                    >> setField "testName" n
                                    >> setField "duration" d
                                    >> setField "message" (newmsg.TrimEnd('\n')))
                            }
                    }
  let config = [
    Printer customFail
  ]
  runTestsWithCLIArgs config args tests
