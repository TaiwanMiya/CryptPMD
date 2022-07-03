class PyAsn1Error(Exception):...

class ValueConstraintError(PyAsn1Error):...

class SubstrateUnderrunError(PyAsn1Error):...

class PyAsn1UnicodeError(PyAsn1Error, UnicodeError):
    def __init__(self, message, unicode_error=None):
        if isinstance(unicode_error, UnicodeError):
            UnicodeError.__init__(self, *unicode_error.args)
        PyAsn1Error.__init__(self, message)


class PyAsn1UnicodeDecodeError(PyAsn1UnicodeError, UnicodeDecodeError):...

class PyAsn1UnicodeEncodeError(PyAsn1UnicodeError, UnicodeEncodeError):...