let webhook = process.argv[2];
let branch = process.argv[3];
let commit = process.argv[4];

const whook = require("webhook-discord");

const hook = new whook.Webhook(webhook);

hook.err("Travis CI", "**Build failed tests on Windows**: " + branch + " " + commit);