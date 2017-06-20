#ifndef SIMPLE_IRISES_SAMPLE_WX_VERSION_INFO_H_INCLUDED
#define SIMPLE_IRISES_SAMPLE_WX_VERSION_INFO_H_INCLUDED

namespace Neurotec
{
	namespace Samples
	{

#define SIMPLE_IRISES_SAMPLE_WX_PRODUCT_NAME "Simple Irises Sample"
#define SIMPLE_IRISES_SAMPLE_WX_INTERNAL_NAME "SimpleIrisesSampleWX"
#define SIMPLE_IRISES_SAMPLE_WX_TITLE SIMPLE_IRISES_SAMPLE_WX_PRODUCT_NAME

#define SIMPLE_IRISES_SAMPLE_WX_COMPANY_NAME "Neurotechnology"
#ifdef N_PRODUCT_LIB
#define SIMPLE_IRISES_SAMPLE_WX_FILE_NAME SIMPLE_IRISES_SAMPLE_WX_INTERNAL_NAME "Lib.exe"
#else
#define SIMPLE_IRISES_SAMPLE_WX_FILE_NAME SIMPLE_IRISES_SAMPLE_WX_INTERNAL_NAME ".exe"
#endif
#define SIMPLE_IRISES_SAMPLE_WX_COPYRIGHT "Copyright (C) 2015-2017 Neurotechnology"
#define SIMPLE_IRISES_SAMPLE_WX_VERSION_MAJOR 9
#define SIMPLE_IRISES_SAMPLE_WX_VERSION_MINOR 0
#define SIMPLE_IRISES_SAMPLE_WX_VERSION_BUILD 0
#define SIMPLE_IRISES_SAMPLE_WX_VERSION_REVISION 0
#define SIMPLE_IRISES_SAMPLE_WX_VERSION_STRING "9.0.0.0"

	}
}

#endif // SIMPLE_IRISES_SAMPLE_WX_VERSION_INFO_H_INCLUDED