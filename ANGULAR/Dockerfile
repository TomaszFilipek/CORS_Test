FROM node:18 AS build

WORKDIR /app

COPY package*.json ./

RUN npm install

COPY . .

RUN export NG_CLI_ANALYTICS="false" && npm run build --prod

FROM nginx:alpine

RUN ls -l

COPY --from=build /app/dist/garage-manager-front /usr/share/nginx/html
COPY ./nginx.conf /etc/nginx/nginx.conf

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
	