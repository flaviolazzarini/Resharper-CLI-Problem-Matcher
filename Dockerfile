FROM andmos/dotnet-script

COPY main.csx /main.csx
COPY json_types.csx /json_types.csx
COPY temp.xml /temp.xml

ENTRYPOINT ["./main.csx"]
