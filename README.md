# SimpleAutomationWebServer
Simple HTTP server for windows which allows execution of events triggered by POST / GET reuests

Currently listens on port 8090, what it does is then wait for a GET request in localhost:8090/space

Then it sends the SpaceBar keystroke to the currently active window.

I  wanted to use my pebble watch to pause / play videos, using HTTP Push by Sean Konagaya, I am now able to do this.

Using basic HTTP server provided by David Jeske at http://www.jmarshall.com/easy/http/

To run simply build and run SimpleAutomationWebServer.exe

Or run SimpleAutomationWebServer.exe debug to leave the console window open.
