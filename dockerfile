FROM traefik:v2.2
RUN apk add curl
COPY traefik.toml $HOME/.config/traefik.toml