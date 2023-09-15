sudo docker stop $(sudo docker ps -aq -f name=subseq)
sudo docker rm $(sudo docker ps -aq -f name=subseq) 
sudo docker build -t test/subseq:1.1  . 
sudo docker run --name subseq --network host -i -d test/subseq:1.1 
sudo docker exec -d -w / subseq git clone https://github.com/newkisoft/731f1444-f6b3-49f5-ba7f-1215977e431b
sudo docker exec -d -w /731f1444-f6b3-49f5-ba7f-1215977e431b/731f1444-f6b3-49f5-ba7f-1215977e431b/ subseq dotnet run

