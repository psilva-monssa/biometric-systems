#!/bin/sh

chmod a+x ./NServer
LD_LIBRARY_PATH=${LD_LIBRARY_PATH}:../../../Lib/Linux_x86/ ./NServer -c NServer.ODBC_Sample.conf "$@"
