docker build -t traefik_rp .
docker build -t simpleapp -f SimpleApp/dockerfile .
docker stack deploy -c traefik.yml traefik
# docker stack deploy -c simpleapp.yml simpleapp
docker exec -it $(docker ps -f name=traefik_traefik -q) curl -X GET http://simpleapp/