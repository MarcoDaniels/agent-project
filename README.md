# agent-project

_agent-project is the agent responsible for retrieving all projects information to the operator_

## routes
```
/agent/project/,
/agent/project/{name},
/agent/wakeup,
/agent/help
```

agent-project is part of [my little virtual friend](http://mylittlevirtualfriend.com) setup.

## deploy to appharbor
```
dotnet publish
```
```
cd bin/Debug/netcoreapp2.0/publish
```
```
appharbor deploy -a <project-name>
```

## todo
- [x] wakeup endpoint
- [ ] setup authentication for post/put/delete endpoints
- [ ] implement post/put/delete endpoints
- [ ] setup a database instead of inMemory?
