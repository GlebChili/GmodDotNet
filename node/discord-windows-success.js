let webhook = process.argv[2];
let branch = process.argv[3];
let commit = process.argv[4];
let commit_message = process.argv[5];

const whook = require("webhook-discord");

const hook = new whook.Webhook(webhook);

hook.success("Travis CI", "**Build successfully passed tests on Windows**: " + branch + " " + commit + " " + "\"" + commit_message + "\"");
