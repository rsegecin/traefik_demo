# Traefik dotnet core example

This project intends to demonstrate a simple use case of traefik reverse proxy where a dotnet project responds with a greeting to a GET http method on root ('/') and ('/sub') endpoints but it is accessed through `/simpleapp` and `/simpleapp/sub` **by traefik**.



### Build and Run

This demo requires Docker. 

- Run `build.sh` to create the images and stacks where traefik runs on Swarm mode. 

```sh
$ sh build.sh
$ docker exec -it $(docker ps -f name=traefik_traefik -q) curl -X GET http://simpleapp/
```

License
----

MIT

**Free Software, Hell Yeah!**

   [issue]: <https://github.com/dotnet/runtime/issues/41260>
