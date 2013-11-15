﻿/// Declares resource (JS/CSS) dependencies.
module Website.Dependencies

open IntelliFactory.WebSharper

/// Declare how to load Twitter Bootstrap resources from the CDN.
/// Declare that Twitter Bootstrap depends on jQuery (so that jQuery is included first).
[<Require(typeof<JQuery.Resources.JQuery>)>]
[<Sealed>]
type TwitterBootstrap() =
    inherit Resources.BaseResource("//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.1/",
        "js/bootstrap.min.js", "css/bootstrap-combined.min.css")

[<Require(typeof<JQuery.Resources.JQuery>)>]
[<Sealed>]
type QUnit() =
    inherit Resources.BaseResource("//code.jquery.com/qunit/",
        "qunit-1.12.0.js", "qunit-1.12.0.css")

[<assembly: Require(typeof<TwitterBootstrap>)>]
[<assembly: Require(typeof<QUnit>)>]
do ()
