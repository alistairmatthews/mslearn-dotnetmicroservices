Here are the finished files for the exercises.

- In the **backend** folder, create a file named **Dockerfile** and copy the contents of the dockerfile included in this folder to the new file.
- Run the commands `docker build -t productsbackend .` and then `docker run -it --rm -p 5200:80 --name productsbackendcontainer productsbackend` to run the backend as a web service. Browse to http://localhost:5200/productinfo to see the product catalog.
- In the root directory, create a file named **docker-compose.yml** and copy the contents of the docker-compose.yml file in this folder to the new file.
- Run the commands `docker-compose build` and `docker-compose up` to build and run the website. Browse to http://localhost:5902 to see the website running.
